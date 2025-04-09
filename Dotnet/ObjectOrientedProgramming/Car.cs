public class Car(string make)
{
    // field
    private int currentSpeed = 0;

    // properties
    public string Make { get; set; } = make;
    public string Model { get; set; } = "";
    public int CurrentSpeed
    {
        get
        {
            return currentSpeed;
        }

        set
        {
            if (EngineRunning)
            {
                currentSpeed = value;
                if (currentSpeed < 0)
                {
                    currentSpeed = 0;
                }
            }
            else
            {
                throw new Exception("Cannot set the speed when the engine is not running.");
            }
        }
    }
    public bool EngineRunning { get; set; } = false;

    // methods
    public void StartEngine()
    {
        EngineRunning = true;
    }

    public void StopEngine()
    {
        EngineRunning = false;
    }

    public void Accelerate()
    {
        CurrentSpeed += 10;
    }

    public void Decelerate()
    {
        CurrentSpeed -= 10;
    }
}
