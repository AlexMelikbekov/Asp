using System.Collections.Generic;

namespace DanfossTestAspProject.Models
{
    public class Client : EntityBase
    {
        public Client()
        {
            SpecialOffers = new List<SpecialOffer>();
        }

        /// <summary>
        /// Инн клиента.
        /// </summary>
        public int IdentificationNumber { get; set; }

        /// <summary>
        /// КПП клиента.
        /// </summary>
        public int Kpp { get; set; }

        /// <summary>
        /// Юридический адрес клиента.
        /// </summary>
        public string JuridicalAddress { get; set; }

        /// <summary>
        /// Наименование клиента.
        /// </summary>
        public string JuridicalClientName { get; set; }

        /// <summary>
        /// ФИО контактного лица клиента.
        /// </summary>
        public string ContactClientName { get; set; }

        /// <summary>
        /// Телефон контактного лица клиента.
        /// </summary>
        public string MobilePhoneClient { get; set; }

        /// <summary>
        /// Email контактного лица клиента.
        /// </summary>
        public string EmailClient { get; set; }

        /// <summary>
        /// Условия и скидки при заключении договора.
        /// </summary>
        public List<SpecialOffer> SpecialOffers { get; set; }
    }
}
