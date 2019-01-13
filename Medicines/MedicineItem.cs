using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Medicines
{
  public class MedicineItem : INotifyPropertyChanged
  {
    private int Days;
    private float UsePerDay;

    /// <summary>
    /// Name of the medicine
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Information about the medicine
    /// </summary>
    public string Information { get; set; }

    /// <summary>
    /// Number of medicines per strip
    /// </summary>
    public int PiecesPerStrip { get; set; }

    /// <summary>
    /// Number of strips per box
    /// </summary>
    public int StripsPerBox { get; set; }

    /// <summary>
    /// Number of medicine per box
    /// This could also be a calculation
    /// </summary>
    public int PiecesPerBox { get; set; }

    /// <summary>
    /// Is the number of medincines per periode fixed?
    /// </summary>
    public bool UseFixed { get; set; }

    /// <summary>
    /// Number of days of the periode
    /// </summary>
    private int _UseDaysInPeriode;
    public int UseDaysInPerode
    {
      get => _UseDaysInPeriode;
      set
      {
        if (_UseDaysInPeriode != value)
        {
          _UseDaysInPeriode = value;
          Actual = EstimateActualStock();
          OnPropertyChanged("Actual");
        }
      }
    }

    /// <summary>
    /// Number of medicines per periode
    /// </summary>
    private int _UsePerPeriode;
    public int UsePerPeriode
    {
      get => _UsePerPeriode;
      set
      {
        if (_UsePerPeriode != value)
        {
          _UsePerPeriode = value;
          //Actual = EstimateActualStock();
          OnPropertyChanged("Actual");
        }
      }
    }

    /// <summary>
    /// Recording date of the count of medicines
    /// </summary>
    private DateTime _RecordingDate;
    public DateTime RecordingDate
    {
      get => _RecordingDate;
      set
      {
        if (_RecordingDate != value)
        {
          _RecordingDate = value;
          Days = (DateTime.Now.Date - RecordingDate).Days;
          OnPropertyChanged("Actual");
        }
      }
    }

    /// <summary>
    /// Is it a automatic service for the refilling of the stock?
    /// </summary>
    public bool IsService { get; set; }

    /// <summary>
    /// Counted medicines in stock at the recording date.
    /// </summary>
    public int Stock { get; set; }

    /// <summary>
    /// Estimated date when the stock 0 (calculated)
    /// </summary>
    private DateTime _EmptyDate;
    public DateTime EmptyDate
    {
      get => EstimateEmptyDate();
      set
      {
        _EmptyDate = EstimateEmptyDate();
        OnPropertyChanged("Actual");
      }
    }

    /// <summary>
    /// Estimated number of medicines for today (calculated)
    /// Is depending on UsePerPeriode and UseDaysInPerode
    /// </summary>
    private int _Actual;

    public int Actual
    {
      get => EstimateActualStock();
      set
      {
        _Actual = EstimateActualStock();
        OnPropertyChanged("Actual");
        EmptyDate = EstimateEmptyDate();
        OnPropertyChanged("EmpyDate");
      }
    }

    private int EstimateActualStock()
    {
      if (UseDaysInPerode == 0)
      {
        UsePerDay = 1;
      }
      else
      {
        UsePerDay = UsePerPeriode / UseDaysInPerode;
      }
      return Stock - (int)(Days * UsePerDay);
    }

    private DateTime EstimateEmptyDate()
    {
      if (UsePerDay == 0)
      {
        return DateTime.Now;
      }
      return DateTime.Now.Date.AddDays((int)(Actual / UsePerDay));
    }

    #region Notification interface
    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
  }
}
