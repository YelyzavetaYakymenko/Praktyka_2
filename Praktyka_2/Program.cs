using System;
using System.Collections.Generic;

public class Patient
{
    private string name;
    private float date_of_birth;
    private uint insurance_number;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float Date_of_birth
    {
        get { return date_of_birth; }
        set { date_of_birth = value; }
    }

    public uint Insurance_number
    {
        get { return insurance_number; }
        set { insurance_number = value; }
    }

    public Patient(string name, float date_of_birth, uint insurance_number)
    {
        Name = name;
        Date_of_birth = date_of_birth;
        Insurance_number = insurance_number;
    }

    public virtual void RecDiagnosis(string diagnosis)
    {
    }

    public virtual void ShowMedCard()
    {
    }
}

public class Doctor : Patient
{
    private string specialization;

    public Doctor(string name, float date_of_birth, uint insurance_number, string specialization)
        : base(name, date_of_birth, insurance_number)
    {
        this.specialization = specialization;
    }

    public void SetDiagnosis(Patient patient, string diagnosis)
    {
        patient.RecDiagnosis(diagnosis);
    }
}

public class MedCard : Patient
{
    private List<string> Diagnoses { get; set; }

    public MedCard(string name, float date_of_birth, uint insurance_number)
        : base(name, date_of_birth, insurance_number)
    {
        Diagnoses = new List<string>();
    }

    public override void RecDiagnosis(string diagnosis)
    {
        Diagnoses.Add(diagnosis);
    }

    public override void ShowMedCard()
    {
        Console.WriteLine("Ім'я пацієнта: " + Name);
        Console.WriteLine("Дата народження: " + Date_of_birth);
        Console.WriteLine("Номер страховки: " + Insurance_number);
        Console.WriteLine("Діагнози:");
        foreach (var diagnosis in Diagnoses)
        {
            Console.WriteLine(diagnosis);
        }
    }
}
