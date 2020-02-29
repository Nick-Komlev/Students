using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool st_bool = false;
        bool ds_bool = false;
        bool sc_bool = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void StudAdd_Click(object sender, EventArgs e)
        {
            AddBox.Visible = true;
            Ok.Visible = true;
            AddBox.Focus();


            st_bool = true;
            ds_bool = false;
            sc_bool = false;

            StudDel.Enabled = false;
            DiscDel.Enabled = false;
            ScoreDel.Enabled = false;
            StudList.Enabled = false;
            DiscList.Enabled = false;
            ScoreList.Enabled = false;
            Show.Enabled = false;


        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (AddBox.Text.Length < 1)
            {
                MessageBox.Show(
                    "Некорректный ввод",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                if (st_bool == true) StudList.Items.Add(AddBox.Text);
                else if (ds_bool == true) DiscList.Items.Add(AddBox.Text);
                else if (sc_bool == true) ScoreList.Items.Add(AddBox.Text);

                StudDel.Enabled = true;
                DiscDel.Enabled = true;
                ScoreDel.Enabled = true;
                StudList.Enabled = true;
                DiscList.Enabled = true;
                ScoreList.Enabled = true;
                Show.Enabled = true;

                st_bool = false;
                ds_bool = false;
                sc_bool = false;

                AddBox.Visible = false;
                Ok.Visible = false;
                AddBox.Text = "";
            }
        }

        private void DiscAdd_Click(object sender, EventArgs e)
        {
            AddBox.Visible = true;
            Ok.Visible = true;
            AddBox.Focus();


            st_bool = false;
            ds_bool = true;
            sc_bool = false;

            StudDel.Enabled = false;
            DiscDel.Enabled = false;
            ScoreDel.Enabled = false;
            StudList.Enabled = false;
            DiscList.Enabled = false;
            ScoreList.Enabled = false;
            Show.Enabled = false;
        }

        private void ScoreAdd_Click(object sender, EventArgs e)
        {
            AddBox.Visible = true;
            Ok.Visible = true;
            AddBox.Focus();


            st_bool = false;
            ds_bool = false;
            sc_bool = true;

            StudDel.Enabled = false;
            DiscDel.Enabled = false;
            ScoreDel.Enabled = false;
            StudList.Enabled = false;
            DiscList.Enabled = false;
            ScoreList.Enabled = false;
            Show.Enabled = false;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (StudList.Items.Contains(StudList.Text) == false) StudList.Text = "<Выберите строку>";
            if (DiscList.Items.Contains(DiscList.Text) == false) DiscList.Text = "<Выберите строку>";
            if (StudList.Text == "<Выберите строку>" | DiscList.Text == "<Выберите строку>" | ScoreList.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "В списках выбраны пустые значения",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                ShowLbl.Text = "Вывод: Студент " + StudList.Text + " имеет по дисциплине \"" + DiscList.Text + "\" оценку: " + ScoreList.SelectedItem.ToString();
            }
        }

        private void StudDel_Click(object sender, EventArgs e)
        {
            if (StudList.Text == "<Выберите строку>")
            {
                MessageBox.Show(
                    "Выберите студента",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                StudList.Items.Remove(StudList.SelectedItem);
                if (StudList.Items.Count < 1) StudList.Text = "<Выберите строку>";
            }
        }

        private void DiscDel_Click(object sender, EventArgs e)
        {
            if (DiscList.Text == "<Выберите строку>")
            {
                MessageBox.Show(
                    "Выберите дисциплину",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                DiscList.Items.Remove(DiscList.SelectedItem);
                if (DiscList.Items.Count < 1) DiscList.Text = "<Выберите строку>";
            }
        }

        private void ScoreDel_Click(object sender, EventArgs e)
        {
            if (ScoreList.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Выберите оценку",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                ScoreList.Items.Remove(ScoreList.SelectedItem);
                if (ScoreList.Items.Count < 1) ScoreList.Text = "<Выберите строку>";
            }
        }
    }
}
