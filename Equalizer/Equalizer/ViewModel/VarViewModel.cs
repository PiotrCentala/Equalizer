using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Equalizer
{
    /// <summary>
    /// In this class we put all ViewModels 
    /// </summary>
    public class VarViewModel :BaseViewModel
    {
        /// <summary>
        /// In here all the objects are created
        /// </summary>
        public VarViewModel()
        {
            _canExecute = true;
            VariableInput = new Variable();
            VariablesList = new ObservableCollection<Variable>(Structure.InitializeList());
        }
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
        public Variable VariableInput { get; set; }

        /// <summary>
        /// list containing all equations given by user
        /// </summary>
        public ObservableCollection<Equation> EquationsList { get; set; }
        /// <summary>
        /// list containing all variables given by user
        /// </summary>
        public ObservableCollection<Variable> VariablesList { get; set; }
        /// <summary>
        /// This variable is gotten when button is clicked
        /// </summary>
        private ICommand _clickCommand;
        /// <summary>
        /// handling response for private _clickCommand question, triggers Action
        /// </summary>
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => ButtonClicked(), _canExecute));
            }
        }
        /// <summary>
        /// when true, its possible to click a button
        /// </summary>
        private bool _canExecute;
        /// <summary>
        /// Action triggered when button clicked
        /// </summary>
        public void ButtonClicked()
        {
 
            VariablesList.Add( Structure.UpdateList(VariableInput, VariablesList.ToList()).Last());
            VariableInput = new Variable();
        }
    }
}
