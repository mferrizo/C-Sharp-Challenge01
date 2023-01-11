public class User
{
	private int id;
	private string name;
	private string surName;
	private string userName;
	private string password;
	private string mail;
};

public class Product
{
	private int id;
	private string description;
	private float cost;
	private float salePrice;
	private int stock;
	private int idUsername;
};

public class Sale
{
	private int id;
	private string comment;
	private int idUsername;
};

public class soldOut
{
	private int id;
	private int idProduct;
	private int stock;
	private int idSale;
};
	
	
	
	 	