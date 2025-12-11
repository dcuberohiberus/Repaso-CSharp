namespace Luisma4
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("[Program.cs] - Main: Inicio del programa.");

            Console.WriteLine("[Program.cs] - Main: Definimos la Request.");
            DarioRequest request = new()
            {
                Id = 1,
                Name = "Dario",
                Date = DateTime.Now,
                Married = false,
                Hobbies = "Basketball"
            };

            Console.WriteLine("[Program.cs] - Main: Request definida: {0}", request);

            DarioServiceRequest dsr = new DarioServiceRequest();
            dsr = ProcessRequest(request);

            Console.WriteLine("[Program.cs] - Main: Request procesada y mapeada a DarioServiceRequest: {0}", dsr);

            Microservicio ms = new Microservicio();
            DarioServiceResponse darioServiceResponse = ms.MetodoMicro(dsr);

            Console.WriteLine("[Program.cs] - Main: Response recibida del microservicio: {0}", darioServiceResponse);

            DarioResponse dr = ProcessResponse(darioServiceResponse);

            Console.WriteLine("[Program.cs] - Main: Response procesada y mapeada a DarioResponse: {0}", dr);

            Console.WriteLine("[Program.cs] - Main: Fin del programa.");
        }//end:main

        public static DarioServiceRequest ProcessRequest(DarioRequest request)
        {
            Console.WriteLine("[Program.cs] - ProcessRequest: Inicio del método. Request: {0}", request);

            DarioServiceRequest serviceRequest = new()
            {
                Id = request.Id,
                Name = request.Name,
                Date = request.Date,
                Married = request.Married,
                Hobbies = request.Hobbies
            };

            Console.WriteLine("[Program.cs] - ProcessRequest: Fin del método. ServiceRequest: {0}", serviceRequest);

            return serviceRequest;
        }

        public static DarioResponse ProcessResponse(DarioServiceResponse dsr)
        {
            Console.WriteLine("[Program.cs] - ProcessResponse: Inicio del método. ServiceResponse: {0}", dsr);

            DarioResponse dr = new DarioResponse()
            {
                Id = dsr.Id,
                Name = dsr.Name,
                Date = dsr.Date,
                Married = dsr.Married,
                Hobbies = dsr.Hobbies
            };

            Console.WriteLine("[Program.cs] - ProcessResponse: Fin del método. Response: {0}", dr);

            return dr;
        }
    }//end.program
}