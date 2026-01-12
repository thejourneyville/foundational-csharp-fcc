namespace Exercises.ControlFlow
{
    public static class SwitchStatements
    {
        public static void Run()
        {
            // SKU = Stock Keeping Unit
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "02-BL-S";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            foreach (string section in product)
            {
                switch (section)
                {
                    case "01":
                        type = "Sweat shirt";
                        break;

                    case "02":
                        type = "T-Shirt";
                        break;
                    
                    case "03":
                        type = "Sweat pants";
                        break;
                    
                    case "BL":
                        color = "Black";
                        break;

                    case "MN":
                        color = "Maroon";
                        break;

                    case "S":
                        size = "Small";
                        break;

                    case "M":
                        size = "Medium";
                        break;
                    
                    case "L":
                        size = "Large";
                        break;

                    default:
                        // checks each section from the loop, 
                        // if the section is empty and the variable is empty, will populate in order
                        if (type == "")
                            type = "Other";
                        if (color == "")
                            color = "White";
                        if (size == "")
                            size = "One Size Fits All";
                        break;
 
                }
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }

    }
}

