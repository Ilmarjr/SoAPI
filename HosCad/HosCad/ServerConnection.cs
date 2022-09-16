using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosCad
{
    public class ServerConnection
    {
        public delegate void EventHandler(string result);

        //eventos que ssão desparados após sua respectiva operação
        public event EventHandler cadastroResult;
        public event EventHandler DeleteResult;
        public event EventHandler atualizarResult;

        Guest gstVO;
        public Form ParentForm { get; set; }

        //método que conecta com a API para realizar o cadastro do Hóspede
        public void cadastrar(Guest guest)
        {
            gstVO = new Guest();
            using (var client = new HttpClient())
            {
                var endPoint = new Uri("https://localhost:44314/api/Data");
                var newGuest = new Guest()
                {
                    Nome = guest.Nome,
                    Cpf = guest.Cpf,
                    Telefone = guest.Telefone,
                    Email = guest.Email
                };

                var newGuestJson= JsonConvert.SerializeObject(newGuest);
                var payLoad = new StringContent(newGuestJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endPoint, payLoad).Result.Content.ReadAsStringAsync().Result;
                //invoca o evento de resultado
                ParentForm.Invoke(cadastroResult, result.ToString());
            }
        }

        //método que conecta com a API para buscar os dados do Hóspede
        public Guest buscarGuest(string cpf)
        {
            Guest newGuest;

            using (var client = new HttpClient())
            {
                var endPoint = new Uri("https://localhost:44314/api/Data/1?cpf=" + cpf);

                var result = client.GetAsync(endPoint).Result.Content.ReadAsStringAsync().Result;

                newGuest = JsonConvert.DeserializeObject<Guest>(result);
            }
            return newGuest;
        }

        //método que conecta com a API para realizar a atualização do Registro do Hóspede
        public void atualizarGuest(Guest guest)
        {
            gstVO = new Guest();
            using (var client = new HttpClient())
            {
                var endPoint = new Uri("https://localhost:44314/api/Data");
                var newGuest = new Guest()
                {
                    Nome = guest.Nome,
                    Cpf = guest.Cpf,
                    Telefone = guest.Telefone,
                    Email = guest.Email
                };

                var newGuestJson = JsonConvert.SerializeObject(newGuest);
                var payLoad = new StringContent(newGuestJson, Encoding.UTF8, "application/json");
                var result = client.PutAsync(endPoint, payLoad).Result.Content.ReadAsStringAsync().Result;
                //invoca o evento de resultado
                atualizarResult.Invoke(result);
            }

        }

        //método que conecta com a API para excluir o cadastro do Hóspede
        public void excluirGuest(string cpf)
        {
            using (var client = new HttpClient())
            {
                var endPoint = new Uri("https://localhost:44314/api/Data?cpf=" + cpf);

                var result = client.DeleteAsync(endPoint).Result.Content.ReadAsStringAsync().Result;
                //invoca o evento de resultado
                DeleteResult.Invoke(result);

            }
        }

    }
}
