using System;
using System.Collections.Generic;

public class Circuit

{
    public int CircuitId { get; set; }
    public string CircuitName { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public double LengthOfTrack { get; set; }


    public override string ToString()
    {
        return $"{CircuitName} ({Country})";
    }
}
