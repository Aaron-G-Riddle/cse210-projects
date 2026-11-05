class BreathingActivity : BaseActivity
{

    public BreathingActivity(): base()
    {
    }
    public void RunActivity()
    {
        // call StartActivity() method

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        while (! HasTimerExpired())
        {
            RunCountDownMessage("Breathe in ...", 4);
            RunCountDownMessage("Breathe out...", 6);
        }

        // call EndActivity() method
    }
}