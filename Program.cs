// SKU = Stock Keeping Unit. 

string sku = "01 -MN--L";

string[] product = sku.Split('-', StringSplitOptions.RemoveEmptyEntries); // split ja separa a classe em arrays.
// StringSplitOptions.RemoveEmptyEntries remove separadores duplicados

string type = ""; // aqui a variavel produc da classe string separadinha em indices [0],[1],[2].
string color = "";
string size = "";

for (int i = 0; i < product.Length;i++)
{
	product[i] = product[i].Trim();
}
switch (product[0])
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
	default:
	type = "Other";
	break;
}
switch (product[1])
{
	case "BL":
	color = "Black";
	break;
	case "MN":
	color = "Maroon";
	break;
	case "WT":
	color = "White";
	break;
}
switch (product[2])
{
	case "0S":
	size = "Small";
	break;
	case "M":
	size = "Medium";
	break;
	case "L":
	size = "Large";
	break;
	default:
	size = "One Size Fits All";
	break;
}

Console.WriteLine($"Product: {size} {color} {type}");
