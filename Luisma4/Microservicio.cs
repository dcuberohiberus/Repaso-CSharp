namespace Luisma4
{
    public class Microservicio
    {
        //Método que reciba DarioServiceRequest y que lo mapee en distintos datos modificándolos y que se mapee en ServiceResponse, y la devuelva.
        public DarioServiceResponse MetodoMicro(DarioServiceRequest dsr)
        {
            Console.WriteLine("[Microservicio.cs] - MetodoMicro: Inicio del método. Request: {0}", dsr);

            DarioServiceResponse darioServiceResponse = new DarioServiceResponse();

            darioServiceResponse = MapRequestToResponse(dsr);

            Console.WriteLine("[Microservicio.cs] - MetodoMicro: Fin del método. Response: {0}", darioServiceResponse);
    
            return darioServiceResponse;
        }

        public DarioServiceResponse MapRequestToResponse(DarioServiceRequest dsr)
        {
            Console.WriteLine("[Microservicio.cs] - MapRequestToResponse: Inicio del método. Request: {0}", dsr);

            dsr.Id = 10;
            dsr.Name = "Pedro";
            dsr.Date = DateTime.Now.AddDays(7);
            dsr.Married = true;
            dsr.Hobbies = "Futbol";

            DarioServiceResponse serviceResponse = new()
            {
                Id = dsr.Id,
                Name = dsr.Name,
                Date = dsr.Date,
                Married = dsr.Married,
                Hobbies = dsr.Hobbies
            };

            Console.WriteLine("[Microservicio.cs] - MapRequestToResponse: Fin del método. Response: {0}", serviceResponse);

            return serviceResponse;
        }
    }
}