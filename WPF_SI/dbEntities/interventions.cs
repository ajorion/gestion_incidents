using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WPF_SI.dbEntities
{
    class interventions
    {
        #region Private attributes

        private DateTime _date_intervention;
        private char _details;
        private char _solution;

        #endregion

        #region Public attributes
        [Key]
        public int id { get; set; }

        public int id_machine { get; set; }
        #endregion

        public DateTime date_intervention
        {
            get { return _date_intervention; }
            set { _date_intervention = value; }
        }

        public char details
        {
            get { return _details; }
            set { _details = value; }
        }

        public char solution
        {
            get { return _solution; }
            set { _solution = value; }
        }
    }
}
