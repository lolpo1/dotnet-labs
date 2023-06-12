
using Adapter;

Logger logger = new LoggerAdapter("file.txt");
logger.Warn("It's a warn");
logger.Error("It's an Er");
logger.Log("It's a log");