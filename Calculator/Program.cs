﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }

    /*Написати програму «Калькулятор»
__________________________________________________________________________________
Форма калькулятора повинна містити: 
10 кнопок з цифрами (0..9), 
кнопку десяткової коми, 
кнопку зміни знаку 
чотири кнопки арифметичних дій
кнопку «дорівнює»
кнопку видалення останнього символу (BackSpace)
кнопку очищення дисплею
кнопку повного очищення
TextBox, котрий відіграє роль дисплею

Калькулятор може перебувати у трьох режимах: 
режим введення першого операнда
режим введення другого операнда
режим відображення результату.

Режим введення першого операнда
Калькулятор переходить в цей режим одразу після запуску, а також після натискання кнопки очищення дисплею.
Дисплей містить символ 0, котрий буде замінений першою натисненою цифрою. 
Якщо першою буде натиснена кнопки десяткової коми -- вона додається до вмісту одразу після нуля.
Подальше натискання цифрових кнопок доповнює вміст дисплею -- цифра, що відповідає натисненій кнопці, дописується в кінець. 
При натисканні кнопки десяткової коми -- вона додається до вмісту лише, якщо її там досі не було (тобто, кома може бути лише одна).
Натискання кнопки зміни знаку у будь-який момент змінює знак на протилежний (можна повторювати безліч разів)

Режим введення другого операнда
Калькулятор переходить в цей режим з режиму введення першого операнда або режиму відображення результату після натискання кнопки арифметичної дії.
Значення, що містилося на дисплеї десь запам'ятовується, натомість на дисплеї відображається 0.
Подальша поведінка -- як у режимі введення першого операнда, з однією відмінністю -- натискання кнопки "дорівнює" обчислює результат дії, 
а натискання кнопки арифметичної дії обчислює результат попередньої дії, запам'ятовує його як перший операнд нової дії і переводить калькулятор
знову у режим введення другого операнда.


Режим відображення результату 
Калькулятор переходить в цей режим після натискання кнопки "дорівнює", або обчислення тригонометричної функції (див. нижче).
У цьому режимі при натисканні цифрових кнопок чи  кнопки десяткової коми дисплей очищається і калькулятор переходить в режим введення операнда та вводиться символ, що відповідає натисненій кнопці. 
Натискання кнопки зміни знаку змінює знак на протилежний (можна повторювати безліч разів) але не переводить калькулятор у режим введення операнда (тобто, не можна дописати цифри)


Слід передбачити, щоби вміст «дисплея» змінювався лише "в кінці", тобто, нові цифри додавалися в кінець наявного тексту і при 
натисканні BackSpace видалалася остання цифра. Крім того, «дисплей» може містити лише цифри, кому і знак "мінус".
Це -- умова на 10.



калькулятор має також обробляти натискання на клавіші:
клавіші  «з цифрами», «крапку» та «кому», 
клавіші з символами арифметичних операцій, 
клавішу «Enter» для «дорівнює»
клавішу «F9» для зміни знаку.


*/

}