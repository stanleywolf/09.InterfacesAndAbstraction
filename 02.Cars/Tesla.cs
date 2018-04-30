﻿using System;
using System.Collections.Generic;
using System.Text;

public class Tesla : IElectricCar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak";
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
            .AppendLine($"Batteries")
            .AppendLine(this.Start())
            .AppendLine(this.Stop());
        return sb.ToString().TrimEnd();
    }
}