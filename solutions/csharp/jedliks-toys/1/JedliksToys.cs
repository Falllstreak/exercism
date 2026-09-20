class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {   
        // throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");

        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay()                 method");

        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay()                 method");
        if (!(_batteryPercentage == 0))
        {
        return $"Battery at {_batteryPercentage}%";
        } else {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        // throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        
        if (_batteryPercentage == 0)
        {
            _metersDriven += 0;
            _batteryPercentage -= 0;
        } else {
            _metersDriven += 20;
            _batteryPercentage -= 1;
        }
    }
}
