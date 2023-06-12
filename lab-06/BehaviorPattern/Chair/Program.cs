
using Chair;

AnswerNetwork network = new AnswerNetwork(); 
AnswerTariff tariff = new AnswerTariff();
AnswerPCAdjust adjust = new AnswerPCAdjust();
Operator oper = new Operator();
AnswerEnd end = new AnswerEnd();
network.SetNext(tariff);
tariff.SetNext(adjust);
adjust.SetNext(oper);
oper.SetNext(end);

bool answerFounded = false;
while(!end.LastIntercepter && !answerFounded)
{
    if (network.Handle() == "yes")
        answerFounded = true;
}