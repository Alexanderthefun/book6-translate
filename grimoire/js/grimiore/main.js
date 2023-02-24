console.log("Do you believe in magic?");
console.log("------------------------");

const allSpells = [
    {
        name: "Turn enemy into newt",
        isEvil: true,
        energyRequired: 5.1
    },
    {
        name: "Conjure some gold for a local charity",
        isEvil: false,
        energyRequired: 2.99 
    },
    {
        name: "Give deaf person the ability to heal",
        isEvil: false,
        energyRequired: 12.2 
    },
    {
        name: "Make yourself emperor of the universe",
        isEvil: true,
        energyRequired: 100.0 
    },
    {
        name: "Convince your relatives your political views are correct",
        isEvil: false,
        energyRequired: 2921.5 
    }
]


const makeGoodBook = (allSpells) => {
    const goodBook = allSpells.filter(spell => spell.isEvil == false);
    goodBook.title = "Good Book";
    return goodBook
}
const makeEvilBook = (allSpells) => {
    const evilBook = allSpells.filter(spell => spell.isEvil == true);
    evilBook.title = "Evil Book";
    return evilBook
}

const displaySpellBook = (book) => {
    console.log(book.title)
    for (const spell of book){
        console.log(`   ${spell.name}`)
    }
}

displaySpellBook(makeGoodBook(allSpells))
console.log("")
displaySpellBook(makeEvilBook(allSpells))