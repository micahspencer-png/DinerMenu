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

        string Fish() 
        {
            string fish = "";
            fish = "Fresh Caught Fish~\n This is a test";
            return fish;
        }
        string ChefSpecial() 
        {
            string chef = "";
            chef = "Chef's Special";
            return chef;
        }
        string Soup() 
        {
            string soup = "";
            soup = "Soup of The Day";
            return soup;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = Fish();
        }

        private void ChefSpecialButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = ChefSpecial();
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = Soup();
        }
    }
}
