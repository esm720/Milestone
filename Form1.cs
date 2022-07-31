namespace Milestone
{
    public partial class Form1 : Form
    {
        //ENRIQUE SANCHEZMURILLO CST-150 MILESTONE 2

        //Below we have our inventory class item.
        class inventoryItem
        {
            public string name;
            public string description;
            public decimal price;
            public int quantity;
            public String stock;
        }
        public Form1()
        {
            InitializeComponent();
        }
        //Method that creates item and adjust quantity.
        public void PlayStation(String inventoryAction, int adjustQuant)
        {
            
            //Here we creat our item by using the class item "inventoryItem"
            inventoryItem playStation = new inventoryItem();

                playStation.name = "Playstation 5";
                playStation.description = "Video Game Console";
                playStation.price = 500;
                playStation.quantity = 3;
                if (playStation.quantity != 0 && playStation.quantity > 0)
                {
                    if (playStation.quantity < 5)
                    {
                        playStation.stock = "Limited Stock: " + playStation.quantity + " left";
                    }
                    else
                    {
                        playStation.stock = playStation.quantity + " In Stock";
                    }
                }
                else
                {
                    playStation.stock = "Out of Stock";
                }
            
            

            //Show Inventory 
            if (inventoryAction.Equals("showInventory")){
                ViewPlaystationInventory(playStation);
            }


            //Add item from quantity, will adjust to permanently change quantity later.
            if (inventoryAction.Equals("add"))
            {
                playStation.quantity = playStation.quantity + adjustQuant;
                //Logic to adjust stock statement
                if (playStation.quantity != 0 && playStation.quantity > 0)
                {
                    if (playStation.quantity < 5)
                    {
                        playStation.stock = "Limited Stock: " + playStation.quantity + " left";
                    }
                    else
                    {
                        playStation.stock = playStation.quantity + " In Stock";
                    }
                }
                else
                {
                    playStation.stock = "Out of Stock";
                }
                ViewPlaystationInventory(playStation);
            }


            //Remove item from quantity
            if (inventoryAction.Equals("remove"))
            {
                playStation.quantity = playStation.quantity - adjustQuant;

                //adjust stock statement
                if (playStation.quantity != 0 && playStation.quantity > 0)
                {
                    if (playStation.quantity < 5)
                    {
                        playStation.stock = "Limited Stock: " + playStation.quantity + " left";
                    }
                    else
                    {
                        playStation.stock = playStation.quantity + " In Stock";
                    }
                }
                else
                {
                    playStation.stock = "Out of Stock";
                }
                ViewPlaystationInventory(playStation);
            }

        }
        //Method to show our inventory
        private void ViewPlaystationInventory(inventoryItem item)
        {
            MessageBox.Show(item.name + "\n" + item.description + "\n" + item.price.ToString("c") + "\n" + item.stock);
        }

        //Below we have our driver methods to test the inventory class item.

        //Event handler for "Show Inventory button named button1"
        private void button1_Click(object sender, EventArgs e)
        {
            PlayStation("showInventory",0);
        }
        //Handles the Add Item button by invoking the Playstation method to add to the quantity
        //We will only sent a quantity of 1, that will be determined by the user later.
        private void AddButton_Click(object sender, EventArgs e)
        {
            PlayStation("add", 1);
            MessageBox.Show("One Item Added"); //later we will reflect the actual amount added.
        }
        //Removes item by sending the string "remove", the invoked method determines what do to.
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            PlayStation("remove",1);
            MessageBox.Show("One Item Removed");
        }
        //Here we load our item as soon as the form loads.
        private void Form1_Load(object sender, EventArgs e)
        {
           //To be used at a later time
            
        }
    }
}