using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2__Bart_
{
    public class BestandInfo
    {
        private string _naam;
        private DateTime _opmaakDatum;
        private Guid _guid;

        public BestandInfo() 
        {
            Guid = Guid.NewGuid();
        }
        public BestandInfo(string naam, DateTime opmaakDatum)
        {
            Guid = Guid.NewGuid();
            Naam = naam;
            OpmaakDatum = opmaakDatum;
        }

        public Guid Guid { get { return _guid; } set { _guid = value; } }
        public string Naam { get { return _naam; } set { _naam = value; } }
        public DateTime OpmaakDatum { get {  return _opmaakDatum; } set { _opmaakDatum = value; } }

        public override bool Equals(object? obj) //Bart: Equals check voor Guid
        {
            bool resultaat = false;
            if (obj != null)
            {
                if (GetType() == obj.GetType())
                {
                    BestandInfo bi = (BestandInfo)obj;
                    if (this.Guid == bi.Guid)
                    {
                        resultaat = true;
                    }
                }
            }
            return resultaat;
        }
    }
}
