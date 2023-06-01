using SingleResponsability;
StudentRepository _ = new();
ExportStudent.Export(StudentRepository.GetAll());
Console.WriteLine("Proceso Completado");