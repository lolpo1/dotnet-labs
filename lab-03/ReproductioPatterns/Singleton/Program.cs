







using Singleton;

//var instance = DatabaseRepository.GetInstance();
//var instanc2 = DatabaseRepository.GetInstance();

for (int i = 0; i < 10; i++)
{
    var thread = new Thread(() =>
    {
        DatabaseRepository.GetInstance();
    });
    thread.Start();
}
DatabaseRepository.GetInstance();
