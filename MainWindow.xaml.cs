using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace CpuStressTest
{
  public partial class MainWindow : Window
  {
    private Thread[] _stressTestThreads;

    public MainWindow()
    {
      InitializeComponent();
    }

    // Startet den CPU-Stresstest
    private void StartButton_Click(object sender, RoutedEventArgs e)
    {
      int threadCount = Environment.ProcessorCount;
      int[] fuckU = new int[threadCount];

      _stressTestThreads = new Thread[threadCount];

      for (int i = 0; i < threadCount; i++)
      {
        _stressTestThreads[i] = new Thread(StressTest);
        _stressTestThreads[i].IsBackground = true;
        _stressTestThreads[i].Start();
        double[i] = new double(StressTest);
      }
    }

    private void StressTest()
    {
      while (true)
      {
        for (int i = 0; i < 1000000; i++)
        {
          double result = Math.Sqrt(i);
        }
      }
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = true;
    }
  }
}
