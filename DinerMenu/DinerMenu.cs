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
            //sets the text for the fish
            string fish = "";
            fish = "Fresh Caught Fish~\n This is a test";
            return fish;
        }
        string ChefSpecial() 
        {
            //sets the text for the chef's special
            string chef = "";
            chef = "Chef's Special";
            return chef;
        }
        string Soup() 
        {
            //sets the text for the soup of the day
            string soup = "";
            soup = "Soup of The Day";
            return soup;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            Close();
        }
        private void FishButton_Click(object sender, EventArgs e)
        {
            //clears label text and calls for the fish method data
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = Fish();
        }
        private void ChefSpecialButton_Click(object sender, EventArgs e)
        {
            //clears label text and calls for the chef special method data
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = ChefSpecial();
        }
        private void SoupButton_Click(object sender, EventArgs e)
        {
            //clears label text and calls for the soup method data
            DisplayItemLabel.Text = string.Empty;
            DisplayItemLabel.Text = Soup();
        }
    }
}
