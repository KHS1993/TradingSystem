// Pending - Denied - Accepted 
using System; // Lägger till detta ifall funktionerna behövs från andra filer, vet ej om nödvändigt.

public enum TradeStatus // Ska beskriva vad värdena under, public för att andra klasser ska kunna använda den, tror det behövs på Progran.cs för att se status.
{
  Pending,
  Denied,
  Accepted,
}