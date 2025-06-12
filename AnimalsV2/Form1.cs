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
        BreedTypeController breedsController= new BreedTypeController();
        AnimalController animalController = new AnimalController();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Няма въведени данни моля въведете данни!");
                txtName.Focus();
                return;
            }

            Animal newAnimal = new Animal();
            newAnimal.Age = int.Parse(txtAge.Text);
            newAnimal.Name = txtName.Text;
            newAnimal.BreedTypeId = (int)cmboxBreed.SelectedValue;

            // Ensure AnimalController is properly referenced and accessible
            AnimalController.Create(newAnimal);
            MessageBox.Show("Записът е успешно добавен!");
        }

        private void btnSellectAll_Click(object sender, EventArgs e)
        {
            List<Animal> allAnimals = AnimalController.GetAll();
            listItems.Items.Clear();
            foreach (var item in allAnimals)
            {
                listItems.Items.Add($"{item.Id}. {item.Name} - Age: {item.Age} Breed: {item.BreedTypes.Name}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<BreedType> allBreeds = breedsController.GetAllBreeds();
            cmboxBreed.DataSource = allBreeds;
            cmboxBreed.DisplayMember = "Name";
            cmboxBreed.ValueMember = "Id";

           // btnSelectAll_Click(sender, e);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

            // Ако няма намерен запис, търсим по Id и визуализираме на екрана
            if (string.IsNullOrEmpty(txtName.Text))
            {
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
            else // Ако има намерен вече запис, променяме по полетата
            {
                Animal updatedAnimal = new Animal();
                updatedAnimal.Name = txtName.Text;
                updatedAnimal.Age = int.Parse(txtAge.Text);
                updatedAnimal.BreedTypeId = (int)cmboxBreed.SelectedValue;

                AnimalController.Update(findId, updatedAnimal);
            }

            btnSelectAll_Click(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                findId = int.Parse(txtName.Text);
            }

            Animal findedDog = AnimalController.Get(findId);
            if (findedDog == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            LoadRecord(findedDog);

            DialogResult answer = MessageBox.Show(
                "Наистина ли искате да изтриете запис No " + findId + " ?",
                "PROMPT",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                AnimalController.Delete(findId);
            }

            btnSelectAll_Click(sender, e);

        }

        private void cmboxBreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}