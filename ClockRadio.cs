class ClockRadio
{
    //MEMBER VARIABLES
    public string currentTime;
    public string currentStation;
    public bool isOn;
    public string alarmTime;

    //CONSTRUCTOR
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
    public void setCurrentTime(string currentTime)
    {
        this.currentTime = currentTime;
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