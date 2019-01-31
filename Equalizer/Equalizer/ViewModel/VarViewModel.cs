using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace Equalizer
{
    /// <summary>
    /// In this class we put all ViewModels 
    /// </summary>
    public class VarViewModel :BaseViewModel
    {
        /// <summary>
        /// Input given by user
        /// </summary>
        public string EquationInput { get; set; }
        /// <summary>
        /// output from python sympy function 
        /// </summary>
        public string EquationOuptut { get; set; }
        /// <summary>
        /// List containig all equations given bys user 
        /// </summary>
        public ObservableCollection<Equation> EquationsList { get; set; }
        /// <summary>
        /// list containing all variables given by user
        /// </summary>
        public ObservableCollection<Variable> VariablesList { get; set; }

    }
}
