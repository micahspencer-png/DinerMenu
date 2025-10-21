namespace DinerMenu
{
    //Micah Spencer
    //RCET2265
    //Fall 2025
    //Diner Menu Program
    //https://github.com/micahspencer-png/DinerMenu.git

    public partial class DinerMenu : Form
    {
        public DinerMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = "Fish";
        }

        private void ChefSpecialButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = "Chef's Special";
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = "Soup of The Day";
        }
    }
}
