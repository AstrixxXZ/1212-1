using AnimalsV2.Controlers;
using AnimalsV2.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalsV2
{
    public partial class Form1 : Form
    {
        private readonly BreedTypeController breedsController;
        private readonly AnimalController animalController;

        public Form1()
        {
            InitializeComponent();
            breedsController = new BreedTypeController();
            animalController = new AnimalController();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (breedsController is IDisposable disposableBreeds)
            {
                disposableBreeds.Dispose();
            }
            if (animalController is IDisposable disposableAnimals)
            {
                disposableAnimals.Dispose();
            }
        }

        private void LoadBreeds()
        {
            try
            {
                var currentSelection = cmboxBreed.SelectedValue;
                cmboxBreed.Enabled = true;

                List<BreedType> allBreeds = breedsController.GetAllBreeds();
                
                if (allBreeds == null || allBreeds.Count == 0)
                {
                    MessageBox.Show("Няма налични породи в базата данни!");
                    return;
                }

                cmboxBreed.SelectedIndexChanged -= cmboxBreed_SelectedIndexChanged;
                
                cmboxBreed.DataSource = null;
                cmboxBreed.DataSource = allBreeds;
                cmboxBreed.DisplayMember = "Name";
                cmboxBreed.ValueMember = "Id";

                cmboxBreed.SelectedIndexChanged += cmboxBreed_SelectedIndexChanged;

                if (currentSelection != null && allBreeds.Any(b => b.Id.Equals(currentSelection)))
                {
                    cmboxBreed.SelectedValue = currentSelection;
                }
                else if (cmboxBreed.Items.Count > 0)
                {
                    cmboxBreed.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на породите: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cmboxBreed.Enabled = true;
                txtName.Enabled = true;
                txtAge.Enabled = true;

                LoadBreeds();
                LoadAnimals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на формата: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text)) 
                {
                    MessageBox.Show("Няма въведени данни за име. Моля въведете име!");
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Невалидна възраст. Моля въведете число!");
                    txtAge.Focus();
                    return;
                }

                if (cmboxBreed.SelectedValue == null)
                {
                    MessageBox.Show("Моля изберете порода!");
                    cmboxBreed.Focus();
                    return;
                }

                var newAnimal = new Animal
                {
                    Name = txtName.Text.Trim(),
                    Age = age,
                    BreedTypeId = (int)cmboxBreed.SelectedValue
                };

                // Check for duplicates before adding
                if (AnimalController.IsDuplicate(newAnimal))
                {
                    var duplicate = AnimalController.GetDuplicate(newAnimal);
                    DialogResult result = MessageBox.Show(
                        "Вече съществува животно със същите данни!\n\n" +
                        $"Id: {duplicate.Id}\n" +
                        $"Име: {duplicate.Name}\n" +
                        $"Възраст: {duplicate.Age}\n" +
                        $"Порода: {duplicate.BreedTypes.Name}\n\n" +
                        "Искате ли да обновите съществуващия запис?",
                        "Намерен дубликат", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Load the existing record for update
                        txtId.Text = duplicate.Id.ToString();
                        LoadRecord(duplicate);
                        // Switch focus to the Update button
                        btnUpdate.Focus();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }

                // If no duplicates, proceed with creation
                AnimalController.Create(newAnimal);
                ClearForm();
                MessageBox.Show("Записът е успешно добавен!");
                LoadAnimals();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAge.Clear();
            txtId.Clear();
            if (cmboxBreed.Items.Count > 0)
            {
                cmboxBreed.SelectedIndex = 0;
            }
        }

        private void LoadAnimals()
        {
            try
            {
                var allAnimals = AnimalController.GetAll();
                listItems.Items.Clear();
                foreach (var item in allAnimals)
                {
                    listItems.Items.Add($"{item.Id}. {item.Name} - Age: {item.Age} Breed: {item.BreedTypes.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на списъка: {ex.Message}");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                List<Animal> allAnimals = AnimalController.GetAll();
                listItems.Items.Clear();
                foreach (var item in allAnimals)
                {
                    listItems.Items.Add($"{item.Id}. {item.Name} - Age: {item.Age} Breed: {item.BreedTypes.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при зареждане на списъка: {ex.Message}");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtId.Text);
            }
            Animal findedAnimal = AnimalController.Get(findId);
            if (findedAnimal == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }
            LoadRecord(findedAnimal);
        }

        private void LoadRecord(Animal findedAnimal)
        {
            txtName.Text = findedAnimal.Name;
            txtAge.Text = findedAnimal.Age.ToString();
            cmboxBreed.SelectedValue = findedAnimal.BreedTypeId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int findId))
                {
                    MessageBox.Show("Въведете валидно Id за търсене!");
                    txtId.BackColor = Color.Red;
                    txtId.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    Animal findedAnimal = AnimalController.Get(findId);
                    if (findedAnimal == null)
                    {
                        MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД!");
                        txtId.BackColor = Color.Red;
                        txtId.Focus();
                        return;
                    }
                    LoadRecord(findedAnimal);
                }
                else
                {
                    if (!int.TryParse(txtAge.Text, out int age))
                    {
                        MessageBox.Show("Невалидна възраст!");
                        txtAge.BackColor = Color.Red;
                        txtAge.Focus();
                        return;
                    }

                    if (cmboxBreed.SelectedValue == null)
                    {
                        MessageBox.Show("Моля изберете порода!");
                        cmboxBreed.BackColor = Color.Red;
                        cmboxBreed.Focus();
                        return;
                    }

                    Animal updatedAnimal = new Animal
                    {
                        Name = txtName.Text.Trim(),
                        Age = age,
                        BreedTypeId = (int)cmboxBreed.SelectedValue
                    };

                    AnimalController.Update(findId, updatedAnimal);
                    LoadAnimals();
                    ClearForm();
                    MessageBox.Show("Записът е успешно обновен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при обновяване на записа: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int findId))
                {
                    MessageBox.Show("Въведете валидно Id за търсене!");
                    txtId.BackColor = Color.Red;
                    txtId.Focus();
                    return;
                }

                Animal findedAnimal = AnimalController.Get(findId);
                if (findedAnimal == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД!");
                    txtId.BackColor = Color.Red;
                    txtId.Focus();
                    return;
                }

                LoadRecord(findedAnimal);

                DialogResult answer = MessageBox.Show(
                    $"Наистина ли искате да изтриете запис No {findId}?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    AnimalController.Delete(findId);
                    ClearForm();
                    LoadAnimals();
                    MessageBox.Show("Записът е изтрит успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при изтриване на записа: {ex.Message}");
            }
        }

        private void cmboxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxBreed.SelectedItem != null)
            {
                cmboxBreed.BackColor = SystemColors.Window;
            }
        }
    }
}