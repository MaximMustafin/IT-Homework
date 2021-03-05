using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Example.SystemBlockExample
{
    public class SystemBlockClass
    {
        /// <summary>
        /// Корпус
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Материнская плата
        /// </summary>
        public string MotherBoard { get; set; }
        /// <summary>
        /// Блок питания
        /// </summary>
        public string PSU { get; set; }
        /// <summary>
        /// Центральный процессор
        /// </summary>
        public string CPU { get; set; }
        /// <summary>
        /// Оперативная память
        /// </summary>
        public string RAM { get; set; }
        /// <summary>
        /// Видеокарта
        /// </summary>
        public string VideoAdapter { get; set; }
        /// <summary>
        /// Сетевая карта
        /// </summary>
        public string NetworkAdapter { get; set; }
        /// <summary>
        /// Звуковая карта
        /// </summary>
        public string SoundAdapter { get; set; }
        /// <summary>
        /// Жесткий диск
        /// </summary>
        public string HardDrive { get; set; }
        /// <summary>
        /// SSD
        /// </summary>
        public string SSD { get; set; }        

        public override string ToString()
        {
            return "Ваш системный блок:\n" +
                "Корпус - " + this.Body + "\n" +
                "Материнская плата - " + this.MotherBoard + "\n" +
                "Блок питания - " + this.PSU + "\n" +
                "Центральный процессор - " + this.CPU + "\n" +
                "Оперативная память - " + this.RAM + "\n" +
                "Видеокарта - " + this.VideoAdapter + "\n" +
                "Сетевая карта - " + this.NetworkAdapter + "\n" +
                "Звуковая карта - " + this.SoundAdapter + "\n" +
                "Жесткий диск - " + this.HardDrive + "\n" +
                "SSD - " + this.SSD;
        }
    }
}
