class ClockRadio
{
    //MEMBER VARIABLES
    private string currentTime;
    private string currentStation;
    private bool isOn;
    private string alarmTime;

    //CONSTRUCTOR

    public ClockRadio()
    {

    }
    public ClockRadio(string currentTime, string currentStation, bool isOn, string alarmTime)
    {
        this.currentTime = currentTime;
        this.currentStation = currentStation;
        this.isOn = isOn;
        this.alarmTime = alarmTime;
    }


    public string getCurrentTime()
    {
        return this.currentTime;
    }

    //MEMBER METHODS
    public string setCurrentTime(string currentTime)
    {
        return this.currentTime = currentTime;
    }

    public string getCurrentStation()
    {
        return this.currentStation;
    }

    public void setCurrentStation(string currentStation)
    {
        this.currentStation = currentStation;
    }

    public bool isIsOn()
    {
        return this.isOn;
    }

    public void setIsOn(bool isOn)
    {
        this.isOn = isOn;
    }

    public string getAlarmTime()
    {
        return this.alarmTime;
    }

    public void setAlarmTime(string alarmTime)
    {
        this.alarmTime = alarmTime;
    }

}