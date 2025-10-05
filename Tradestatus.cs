// Pending - Denied - Accepted 
namespace MyTradingApp
{
  // status för framtida trades
  public enum TradeStatus // Ska beskriva vad värdena under, public för att andra klasser ska kunna använda den, tror det behövs på Progran.cs för att se status.
  {
    Pending,
    Denied,
    Accepted,
  }

}