namespace Classes;

public class Account
{
 int _number;
 decimal _balance;
 public Account(int number){
 _number = number;
 }  
 public Account(int number , decimal balance){
    _number= number;
    _balance=balance;
 }  
 public int getNumber(){
    return _number;
 }
 public decimal getBalance(){
    return _balance;
 }
 public string toString(){
    return $"Account[number={_number},balance=${_balance}]";
 }
 public void credit(decimal amount){
      _balance+=amount;
 }
 public void debit(decimal amount){
   if (_balance >= amount){
       _balance-=amount;
   }
   else{
      System.Console.WriteLine("amount exceeded");
   }
 }
}