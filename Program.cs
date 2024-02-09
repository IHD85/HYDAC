using OpgaveZ;


Visitor Jørgen = new Visitor("Jørgen Fog Hansen");
Visitor Mikkel  = new Visitor("Mikkel Holst");
Visitor Simm = new Visitor("Simm");
Visitor Kasper = new Visitor("Kasper Edal");
Visitor Alexander = new Visitor("Alexander Møller");
Visitor Anders = new Visitor("Anders Sørensen");
Visitor René = new Visitor("René Davidsen");
Visitor Karin = new Visitor("Karin Sievers");
Visitor Andy = new Visitor("Andy Widstrup");
Visitor AndersP = new Visitor("Anders Pedersen");
Visitor Rune = new Visitor("Rune Johansen");
Visitor Kim = new Visitor("Kim Kristensen");
Visitor Lars = new Visitor("Lars Jespersen");




Responsible Rene  = new Responsible("Rene Hansen");
Responsible Daniel = new Responsible("Daniel R");
Responsible Kasper1 = new Responsible("Kasper");
Responsible Daniel1 = new Responsible("Daniel");
Responsible Jesper = new Responsible("Jesper Salih");
Responsible no = new Responsible("No One Responsible");

Firma NoFirma = new Firma("Ikke Noget Firma");
Firma Nurr  = new Firma("Nurr elektronik");
Firma Nidec = new Firma("Nidec");
Firma MicroTechnic = new Firma("MicroTechnic");
Firma Tietgen = new Firma("Tietgen");
Firma Caverion = new Firma("Caverion");
Firma IT = new Firma("IT-Forum");
Firma Dustin = new Firma("Dustin");
Firma Microsoft = new Firma("Microsoft");


Visit visit1 = new Visit(new DateOnly(2022, 05, 15), Jørgen,NoFirma ,no , new TimeOnly(), new TimeOnly(), ' ');
Visit visit2 = new Visit(new DateOnly(2022, 05, 15), Mikkel, Nurr, Rene, new TimeOnly(04, 30), new TimeOnly(12, 50), 'x');
Visit visit3 = new Visit(new DateOnly(2022, 05, 15), Simm, Nurr, Rene, new TimeOnly(04, 30), new TimeOnly(12, 50), 'x');
Visit visit4 = new Visit(new DateOnly(2022, 05, 15), Kasper, Nidec, Daniel, new TimeOnly(12, 00), new TimeOnly(12, 45), ' ');
Visit visit5 = new Visit(new DateOnly(2022, 05, 15), Alexander, MicroTechnic,Kasper1, new TimeOnly(13, 00), new TimeOnly(15, 00), ' ');
Visit visit6= new Visit(new DateOnly(2022,05,15),Anders,MicroTechnic,Kasper1,new TimeOnly(13,00),new TimeOnly(15,00),' ');
Visit visit7=new Visit(new DateOnly(2022,05,15),René,MicroTechnic,Kasper1,new TimeOnly(13,00),new TimeOnly(15,00), ' ');
Visit visit8= new Visit(new DateOnly(2022,05,15),Karin,Tietgen,Daniel1,new TimeOnly(14,00),new TimeOnly(14,50), ' ');
Visit visit9= new Visit(new DateOnly(2022,05,16),Andy,Caverion,Daniel1,new TimeOnly(07,30),new TimeOnly(11,40), ' ');
Visit visit10= new Visit(new DateOnly(2022,05,16),AndersP,NoFirma,Daniel1,new TimeOnly(07,40),new TimeOnly(11,40),' ');
Visit visit11 = new Visit(new DateOnly(2022, 05, 16), Rune, IT, Jesper, new TimeOnly(08, 00), new TimeOnly(), 'x');
Visit visit12= new Visit(new DateOnly(2022,05,16),Kim,Microsoft,Jesper,new TimeOnly(14,00),new TimeOnly(17,00), ' ');
Visit visit13 = new Visit(new DateOnly(2022, 05, 16), Lars, Microsoft, Jesper, new TimeOnly(14, 00), new TimeOnly(15, 00), ' ');

VisitLog visitList = new VisitLog();
visitList.visitLog.Add(visit1);
visitList.visitLog.Add(visit2);
visitList.visitLog.Add(visit3);
visitList.visitLog.Add(visit4);
visitList.visitLog.Add(visit5);
visitList.visitLog.Add(visit6);
visitList.visitLog.Add(visit7);
visitList.visitLog.Add(visit8);
visitList.visitLog.Add(visit9);
visitList.visitLog.Add(visit10);
visitList.visitLog.Add(visit11);
visitList.visitLog.Add(visit12);
visitList.visitLog.Add(visit13);

foreach(var visit in visitList.visitLog)
{
    Console.WriteLine($"Dato : {visit.Dato} | Visitor:  {visit.Visitor.Name} | Firma : {visit.Firma.Name} |" +
        $" Rensponsible : {visit.Responsible1.Name} | FromTime: {visit.FromTime} |  ToTime : {visit.ToTime} |" +
        $" Sikkerhedsfolder:  {visit.Sikkerhedsfolder} ");
    Console.WriteLine();
}

Console.ReadLine();
