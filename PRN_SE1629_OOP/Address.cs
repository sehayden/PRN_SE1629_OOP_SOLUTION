﻿namespace PRN_SE1629;
public class Address
{
    public int No { get; set; }
    public string Street { get; set; }
    public string Ward { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public Address(int no, string street, string ward, string district, string city)
    {
        No = no;
        Street = street;
        Ward = ward;
        District = district;
        City = city;
    }

    public override string? ToString()
    {
        return $"[Address = {No}:{Street}:{Ward}:{District}:{City}";
    }
}