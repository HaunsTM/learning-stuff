<div>
    <h1>learning-stuff</h1>
    <p>A <i>(personal)</i> visual studio solution with different projects for the purpose of learning and teachning. Not language or technique specific.</p>

    <article id="stringReversion">
        <h2>Fibonacci</h2>
        <h3>Uppgift</h3>
        <p>Hitta det n:te talet i serien som ges av Fibonacci-talf&ouml;ljden</p>
        <p>
            Fibonaccital &auml;r tal som ing&aring;r i en heltalsf&ouml;ljd, Fibonaccis talf&ouml;ljd, d&auml;r varje tal &auml;r summan av de tv&aring; f&ouml;reg&aring;ende Fibonaccitalen;
            de tv&aring; f&ouml;rsta talen &auml;r 0 och 1. Matematiskt inneb&auml;r det att Fibonaccitalen &auml;r en sekvens F<sub>n</sub>, definierad rekursivt enligt:<br />
            
            <ul>
                <li>F<sub>0</sub> = 0</li>
                <li>F<sub>1</sub> = 1</li>
                <li>F<sub>n</sub >= F<sub>n-1</sub> + F<sub>n-2</sub></li>
            </ul>
        </p>
    </article>
    <article id="fizzBuzz">
        <h2>Fizz Buzz</h2>
        <h3>Uppgift</h3>
        <p>
            Skriv ett program som skriver ut alla tal mellan 1 och 100.
            <ul>
                <li>Om talet &auml;r delbart med 3 skall programmet ist&auml;llet f&ouml;r att skriva ut siffran, skriva ut "Fizz".</li>
                <li>Om talet &auml;r delbart med 5 skall programmet ist&auml;llet skriva ut ordet "Buzz".</li>
                <li>Om talet &auml;r delbart med b&aring;de 3 och 5 skall programmet skriva ut "FizzBuzz".</li>
            </ul>
        </p>
    </article>
    <article id="stringReversion">
        <h2>String reversion</h2>
        <h3>Uppgift</h3>
        <p>
            Ta en str&auml;ng och skriv ut den bakl&auml;nges.
        </p>
    </article>
    <article id="wCFHostingWithWindowsService">
        <h2>WCF med en windows service + enkel console-klient</h2>
        <h3>Uppgift</h3>
        <p>
            Skapa en WCF-service och hosta den i en windows service.
        </p>
        <p>Projektet är implementation av en artikel på <a href="http://www.codeproject.com/Articles/653493/WCF-Hosting-with-Windows-Service">Code Project</a> 
där det demonstreras en enkel WCF-sevice. Servicen består av en enkel kalkylator med de fyra valiga räknesätten:
<pre>[ServiceContract]
  public interface ICalcService
  {
      [OperationContract]
      double Add(double dblNum1, double dblNum2);
      [OperationContract]
      double Subtract(double dblNum1, double dblNum2);
      [OperationContract]
      double Multiply(double dblNum1, double dblNum2);
      [OperationContract]
      double Divide(double dblNum1, double dblNum2);
  }</pre>

        Vidare byggs en installer till projektet:
        <ol>
            <li>Öppna MyCalcWinService i <b>design mode</b> genom att högerklicka på filen. Högerklicka sedan på designytan och välj <b>Add Installer</b> från
context-menyn:
<img src="https://i.imgur.com/pcvBOZo.png"></img></li>
            <li></li>
            <li></li>
        </ol>
        </p>

    </article>
</div>