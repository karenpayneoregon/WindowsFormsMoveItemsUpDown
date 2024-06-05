using System.ComponentModel;
using System.Runtime.CompilerServices;
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DapperLibrary1.Models;

public class Person : INotifyPropertyChanged, ICloneable
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private DateOnly _birthDate;
    private int _rowPosition;

    public int Id
    {
        get => _id;
        set
        {
            if (value == _id) return;
            _id = value;
            OnPropertyChanged();
        }
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (value == _firstName) return;
            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (value == _lastName) return;
            _lastName = value;
            OnPropertyChanged();
        }
    }


    public DateOnly BirthDate
    {
        get => _birthDate;
        set
        {
            if (value.Equals(_birthDate)) return;
            _birthDate = value;
            OnPropertyChanged();
        }
    }

    public int RowPosition
    {
        get => _rowPosition;
        set
        {
            if (value == _rowPosition) return;
            _rowPosition = value;
            OnPropertyChanged();
        }
    }

    public override string ToString() => Id.ToString();
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public object Clone()
    {
        return (Person)MemberwiseClone();

    }
}
