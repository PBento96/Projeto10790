using Loja10790;
using Loja10790.Model;
using Loja10790.ViewModel;
using System.Collections.Generic;
using System.Linq;

internal class MyAccountViewModel : ViewModelBase
{
    private string originalUsername;
    private string username;
    private string firstName;
    private string lastName;
    private string taxID;
    private string dateOfBirth;
    private string hireDate;
    private string terminationDate;
    private string email1;
    private string email2;
    private string phoneNumber1;
    private string phoneNumber2;
    private string addressLine1;
    private string addressLine2;
    private string postcode;
    private string city;
    private string selectedCountry;

    public string Username
    {
        get { return username; }
        set
        {
            if (username != value)
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (firstName != value)
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            if (lastName != value)
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
    }

    public string TaxID
    {
        get { return taxID; }
        set
        {
            if (taxID != value)
            {
                taxID = value;
                OnPropertyChanged(nameof(TaxID));
            }
        }
    }

    public string DateOfBirth
    {
        get { return dateOfBirth; }
        set
        {
            if (dateOfBirth != value)
            {
                dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
    }

    public string HireDate
    {
        get { return hireDate; }
        set
        {
            if (hireDate != value)
            {
                hireDate = value;
                OnPropertyChanged(nameof(HireDate));
            }
        }
    }

    public string TerminationDate
    {
        get { return terminationDate; }
        set
        {
            if (terminationDate != value)
            {
                terminationDate = value;
                OnPropertyChanged(nameof(TerminationDate));
            }
        }
    }

    public string Email1
    {
        get { return email1; }
        set
        {
            if (email1 != value)
            {
                email1 = value;
                OnPropertyChanged(nameof(Email1));
            }
        }
    }

    public string Email2
    {
        get { return email2; }
        set
        {
            if (email2 != value)
            {
                email2 = value;
                OnPropertyChanged(nameof(Email2));
            }
        }
    }

    public string PhoneNumber1
    {
        get { return phoneNumber1; }
        set
        {
            if (phoneNumber1 != value)
            {
                phoneNumber1 = value;
                OnPropertyChanged(nameof(PhoneNumber1));
            }
        }
    }

    public string PhoneNumber2
    {
        get { return phoneNumber2; }
        set
        {
            if (phoneNumber2 != value)
            {
                phoneNumber2 = value;
                OnPropertyChanged(nameof(PhoneNumber2));
            }
        }
    }

    public string AddressLine1
    {
        get { return addressLine1; }
        set
        {
            if (addressLine1 != value)
            {
                addressLine1 = value;
                OnPropertyChanged(nameof(AddressLine1));
            }
        }
    }

    public string AddressLine2
    {
        get { return addressLine2; }
        set
        {
            if (addressLine2 != value)
            {
                addressLine2 = value;
                OnPropertyChanged(nameof(AddressLine2));
            }
        }
    }

    public string Postcode
    {
        get { return postcode; }
        set
        {
            if (postcode != value)
            {
                postcode = value;
                OnPropertyChanged(nameof(Postcode));
            }
        }
    }

    public string City
    {
        get { return city; }
        set
        {
            if (city != value)
            {
                city = value;
                OnPropertyChanged(nameof(City));
            }
        }
    }

    public string SelectedCountry
    {
        get { return selectedCountry; }
        set
        {
            if (selectedCountry != value)
            {
                selectedCountry = value;
                OnPropertyChanged(nameof(SelectedCountry));
            }
        }
    }

    private List<string> countryShortNames;

    public List<string> CountryShortNames
    {
        get { return countryShortNames; }
        set
        {
            if (countryShortNames != value)
            {
                countryShortNames = value;
                OnPropertyChanged(nameof(CountryShortNames));
            }
        }
    }

    public MyAccountViewModel()
    {
        originalUsername = App.CurrentUser;
        Username = originalUsername;
        LoadData();
    }

    private void LoadData()
    {
        using (var context = new AppDbContext())
        {
            var user = context.GetUserByUsername(originalUsername);

            if (user != null)
            {
                var employee = context.t_employees.FirstOrDefault(e => e.login == user.id_login);

                if (employee != null)
                {
                    FirstName = employee.name_first;
                    LastName = employee.name_last;
                    TaxID = employee.tax_id;
                    DateOfBirth = employee.date_birth.HasValue ? employee.date_birth.Value.ToString("yyyy/MM/dd") : string.Empty;
                    HireDate = employee.date_hired.HasValue ? employee.date_hired.Value.ToString("yyyy/MM/dd") : string.Empty;
                    TerminationDate = employee.date_fired.HasValue ? employee.date_fired.Value.ToString("yyyy/MM/dd") : string.Empty;

                    var contact = employee.contacts.HasValue ? context.GetContactById(employee.contacts.Value) : null;

                    if (contact != null)
                    {
                        Email1 = contact.email1;
                        Email2 = contact.email2;
                        PhoneNumber1 = contact.phone1;
                        PhoneNumber2 = contact.phone2;
                        AddressLine1 = contact.address_line1;
                        AddressLine2 = contact.address_line2;
                        Postcode = contact.postcode;
                        City = contact.city;

                        if (contact.country != null)
                        {
                            var country = context.GetCountryById(contact.country.Value);

                            if (country != null)
                            {
                                SelectedCountry = country.short_name;
                            }
                            else
                            {
                                SelectedCountry = string.Empty;
                            }
                        }
                        else
                        {
                            SelectedCountry = string.Empty;
                        }
                    }
                    else
                    {
                        Email1 = string.Empty;
                        Email2 = string.Empty;
                        PhoneNumber1 = string.Empty;
                        PhoneNumber2 = string.Empty;
                        AddressLine1 = string.Empty;
                        AddressLine2 = string.Empty;
                        Postcode = string.Empty;
                        City = string.Empty;
                        SelectedCountry = string.Empty;
                    }
                }
                else
                {
                    FirstName = string.Empty;
                    LastName = string.Empty;
                    TaxID = string.Empty;
                    DateOfBirth = string.Empty;
                    HireDate = string.Empty;
                    TerminationDate = string.Empty;
                    Email1 = string.Empty;
                    Email2 = string.Empty;
                    PhoneNumber1 = string.Empty;
                    PhoneNumber2 = string.Empty;
                    AddressLine1 = string.Empty;
                    AddressLine2 = string.Empty;
                    Postcode = string.Empty;
                    City = string.Empty;
                    SelectedCountry = string.Empty;
                }
            }
        }
    }

    public void RevertChanges()
    {
        Username = originalUsername;
        LoadData();
    }
}