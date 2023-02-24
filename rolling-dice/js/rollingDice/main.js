console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const roll = () => {
    const die = {};
    const dieValue = Math.floor(Math.random() * 6) + 1;
    die.value = dieValue;
    return die;
}

const switchToString = (die) => {
    switch(die.value){
        case 1:
            return "One";
        case 2:
            return "two";
        case 3: 
            return "three";
        case 4: 
            return "four";
        case 5:
            return "five";
        case 6:
            return "six";
    }
    return die;
}

for (let i = 0; i < 10; i++){
let die1 = roll();
let die2 = roll();
let message = `${switchToString(die1)} + ${switchToString(die2)} == ${die1.value + die2.value}`
if (die1.value == die2.value) {
    message += ` DOUBLES!`;
}
console.log(message)
}



