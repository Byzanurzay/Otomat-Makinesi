//Bilerek ingilizce yazdım
//Bazı şeylere çözüm bullamadım döngüler gibi, ya da çok fazla hata verdi anlamadığım. Bende son çağre goto kullandım.
//Ayrıca bi yerden sonrada şakaya ve hikayeye vurdum projeyi, kusura bakmayın.
double customerBalance = 2000;
string[] products = {"Chocolate", "Crackers", "Chips", "Water", "İce tea", "Cola", "Rat flavored coffee"};
double[] prices = {2.5, 3, 1, 1.30, 2, 3.2, 1900};
CHECK:
Console.WriteLine("Are you Doctor Benjam of 1900s?");
Console.WriteLine("Press 1 for Dr.Benjam's admin screen.");
Console.WriteLine("Press 2 for customer screen.");
int decision;
bool check = int.TryParse(Console.ReadLine(), out decision);
if (!check && (decision != 1 || decision != 2))
{
   Console.WriteLine("Pick a valid answer.");
   goto CHECK;
}
if (decision == 1)
{
   START2:
   Console.WriteLine("Heres the famous admin.");
   Console.WriteLine("What do you want to do today?");
   Console.WriteLine("Press 1 to add a product.");
   Console.WriteLine("Press 2 to delete a product.");
   Console.WriteLine("Press 3 to update a price.");
   int adminChoice;
   bool choice = int.TryParse(Console.ReadLine(), out adminChoice);
   if (!choice && (adminChoice != 1 && adminChoice != 2 && adminChoice != 3))
   {
     Console.WriteLine("Try again.");
     goto START2;
   }
   else if (adminChoice == 1)
   {
     ENTRY:
     Console.Write("Enter the product name: ");
     string productName = Console.ReadLine();
     Console.Write("Enter the product price: ");
     double productPrice;
     if (double.TryParse(Console.ReadLine(), out productPrice))
     {
       Array.Resize(ref products, products.Length + 1);
       Array.Resize(ref prices, prices.Length + 1);
       products[products.Length - 1] = productName;
       prices[prices.Length - 1] = productPrice;
       Console.WriteLine($"Product '{productName}' added with price {productPrice}$.");
     }
     else
     {
       Console.WriteLine("Try again.");
       goto ENTRY;
     }
   }
   else if (adminChoice == 2)
   {
      Console.Write("Enter the product name you want to delete: ");
      string productDelete = Console.ReadLine();
      int name = Array.IndexOf(products, productDelete);
      if (name != -1)
      {
        for (int i = name; i < products.Length - 1; i++)
        {
          products[i] = products[i + 1];
          prices[i] = prices[i + 1];
        }
        Array.Resize(ref products, products.Length - 1);
        Array.Resize(ref prices, prices.Length - 1);
        Console.WriteLine($"Product '{productDelete}' deleted.");
      }
      else
      {
        Console.WriteLine($"Product named '{productDelete}' not found.");
      }
   }
   else if (adminChoice == 3)
   {
     Console.Write("Enter the product name to update: ");
     string productUpdate = Console.ReadLine();
     int name = Array.IndexOf(products, productUpdate);
     if (name != -1)
     {
       Console.Write("Enter the new price:");
       double newPrice;
       if (double.TryParse(Console.ReadLine(), out newPrice))
       {
         prices[name] = newPrice;
         Console.WriteLine($"Product '{productUpdate}' got updated to a new price: {newPrice}$.");
       }
       else
       {
         Console.WriteLine("Invalid price entered.");
       }
     }
     else
     {
       Console.WriteLine($"Product '{productUpdate}' not found.");
     }
  }
}
if (decision == 2)
{
  Console.WriteLine("Hmmm. Alright.");
  goto CUSTOMER;
}
else 
{
  Console.WriteLine("There we go!");
  goto CHECK;
}

CUSTOMER:
START:
Console.WriteLine("Hello There customer! Please press the number of the product you want to buy!");
for(int i = 0; i < products.Length; i++)
{
    Console.WriteLine($"{i+1}.{products[i]} - {prices[i]}$");
}

Console.WriteLine("Please pick a product from above.");
double decision1;
bool check3 = double.TryParse(Console.ReadLine(), out decision1);
if (!check3 && (decision1 == 1 || decision1 == 2 || decision1 == 3 || decision1 == 4 || decision1 == 5 || decision1 == 6 || decision1 == 7))
{
   Console.WriteLine("Try again.");
   goto START;
}
if (decision1 == 1)
    {
      DEC:
      Console.WriteLine($"Price of {products[0]} is {prices[0]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment; 
      bool check2 = double.TryParse(Console.ReadLine(), out payment);
      if (!check2)
      {
        Console.WriteLine("Invalid entry. Try again.");
        goto DEC; 
      }
       if (payment == prices[0])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment < prices[0])
        {
          Console.WriteLine("Payment is not enough. Try again");
          goto DEC;       
        }
        else if (payment > prices[0])
        {
          Console.WriteLine("Payment is too much. Try again"); 
          goto DEC;    
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");
          goto DEC;        
        }
      }
    if (decision1 == 2)
    {
      DEC1:
      Console.WriteLine($"Price of {products[1]} is {prices[1]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment2; 
      bool check4 = double.TryParse(Console.ReadLine(), out payment2);
      if (!check4)
      {
        Console.WriteLine("Invalid entry. Try again.");  
        goto DEC1;      
      }
       if (payment2 == prices[2])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment2;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment2 < prices[1])
        {
        Console.WriteLine("Payment is not enough. Try again");
        goto DEC1;        
        }
        else if (payment2 > prices[1])
        {
          Console.WriteLine("Payment is too much. Try again"); 
          goto DEC1;     
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");
          goto DEC1;         
        }
    }
    if (decision1 == 3)
    {
      DEC3:
      Console.WriteLine($"Price of {products[2]} is {prices[2]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment3; 
      bool check5 = double.TryParse(Console.ReadLine(), out payment3);
      if (!check5)
      {
        Console.WriteLine("Invalid entry. Try again.");  
        goto DEC3;      
      }
       if (payment3 == prices[2])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment3;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment3 < prices[2])
        {
        Console.WriteLine("Payment is not enough. Try again");   
        goto DEC3;   
        }
        else if (payment3 > prices[2])
        {
          Console.WriteLine("Payment is too much. Try again");   
          goto DEC3; 
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");  
          goto DEC3;     
        }
    }
    if (decision1 == 4)
    {
      DEC4:
      Console.WriteLine($"Price of {products[3]} is {prices[3]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment4; 
      bool check6 = double.TryParse(Console.ReadLine(), out payment4);
      if (!check6)
      {
        Console.WriteLine("Invalid entry. Try again.");   
        goto DEC4;    
      }
       if (payment4 == prices[3])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment4;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment4 < prices[3])
        {
        Console.WriteLine("Payment is not enough. Try again");  
        goto DEC4;      
        }
        else if (payment4 > prices[3])
        {
          Console.WriteLine("Payment is too much. Try again");    
          goto DEC4;  
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");   
          goto DEC4;     
        }
    }
    if (decision1 == 5)
    {
      DEC5: 
      Console.WriteLine($"Price of {products[4]} is {prices[4]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment5; 
      bool check7 = double.TryParse(Console.ReadLine(), out payment5);
      if (!check7)
      {
        Console.WriteLine("Invalid entry. Try again.");    
        goto DEC5;      
      }
       if (payment5 == prices[4])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment5;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment5 < prices[4])
        {
        Console.WriteLine("Payment is not enough. Try again");    
        goto DEC5;  
        }
        else if (payment5 > prices[4])
        {
          Console.WriteLine("Payment is too much. Try again");   
          goto DEC5; 
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");       
          goto DEC5;
        }
    }
    if (decision1 == 6)
    {
      DEC6:
      Console.WriteLine($"Price of {products[5]} is {prices[5]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      double payment6; 
      bool check8 = double.TryParse(Console.ReadLine(), out payment6);
      if (!check8)
      {
        Console.WriteLine("Invalid entry. Try again.");  
        goto DEC6;
      }
       if (payment6 == prices[5])
       {
         Console.WriteLine("Payment successful! Claim the product.");
         customerBalance -= payment6;
         Console.WriteLine($"(inner voice)I have {customerBalance}$ left....");
         goto START;
        }
        else if (payment6 < prices[5])
        {
        Console.WriteLine("Payment is not enough. Try again");      
        goto DEC6;
        }
        else if (payment6 > prices[5])
        {
          Console.WriteLine("Payment is too much. Try again");    
          goto DEC6;
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");       
          goto DEC6;
        }
    }
     if (decision1 == 7)
    {
      DEC7:
      Console.WriteLine($"Price of {products[6]} is {prices[6]}$.");
      Console.WriteLine("Please enter the required amount of money for the product.");
      Console.WriteLine("Dont buy this.");
      double payment7; 
      bool check9 = double.TryParse(Console.ReadLine(), out payment7);
      if (!check9)
      {
        Console.WriteLine("Invalid entry. Try again.");     
        goto DEC7;   
      }
       if (payment7 == prices[6])
       {
         Console.WriteLine("Payment successful! Claim the product. And don't come back again. Im locking myself.");
         customerBalance -= payment7;
         Console.WriteLine("(inner voice) What? jeez.");
         return;
        }
        else if (payment7 < prices[6])
        {
        Console.WriteLine("Payment is not enough. Try again");      
        goto DEC7;   
        }
        else if (payment7 > prices[6])
        {
          Console.WriteLine("Payment is too much. Try again");    
          goto DEC7;
        }
        else
        {
          Console.WriteLine("Wrong entry. Try again");   
          goto DEC7;    
        }
    }
   