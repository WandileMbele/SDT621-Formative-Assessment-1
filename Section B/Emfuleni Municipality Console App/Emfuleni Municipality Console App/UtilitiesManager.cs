using System;
using System.Collections.Generic;
using System.Linq;

public class UtilitiesManager
{
    public List<ServiceRequest> Requests = new List<ServiceRequest>();
    public List<ServiceRequest> Processed = new List<ServiceRequest>();

    public double CalculateUrgency(ServiceRequest req)
    {
        return (req.PriorityLevel * 2) + req.SeverityLevel - (req.EstimatedHours * 0.5);
    }

    public void DisplayQueue()
    {
        Console.WriteLine("\n--- Pending Requests ---");

        for (int i = 0; i < Requests.Count; i++)
        {
            var req = Requests[i];
            Console.WriteLine($"{i}: {req.Resident.Name} | {req.RequestType} | Urgency: {CalculateUrgency(req):F2}");
        }
    }

    public void ProcessRequest(int index)
    {
        var req = Requests[index];
        Requests.RemoveAt(index);
        Processed.Add(req);

        Console.WriteLine("\n--- PROCESSING REPORT ---");
        Console.WriteLine($"Resident: {req.Resident.Name}");
        Console.WriteLine($"Request: {req.RequestType}");
        Console.WriteLine($"Urgency Score: {CalculateUrgency(req):F2}");
    }

    public void ShowSummary()
    {
        Console.WriteLine("\n--- SUMMARY ---");
        foreach (var r in Processed)
        {
            Console.WriteLine($"{r.Resident.Name} - {r.RequestType}");
        }

        var highest = Processed.OrderByDescending(r => CalculateUrgency(r)).FirstOrDefault();

        if (highest != null)
        {
            Console.WriteLine($"\nHighest Urgency: {highest.RequestType} ({highest.Resident.Name})");
        }
    }
}