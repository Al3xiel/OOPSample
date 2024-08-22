namespace OOPSample.Shared.Domain.Model.ValueObjects;

public record Address(string Street, string Number, string City, string State, string ZipCode, string Country)
{
    public string Adre00ssAsString => $"{Street}, {Number}, {City}, {State}, {ZipCode}, {Country}";
}