class CryptoMiner{
    constructor(_cryptoEachPrint, _price, _tickToPrint){
        this.cryptoEachPrint = _cryptoEachPrint;
        this.price = _price;
        this.tickToPrint = _tickToPrint;
        this.tickUntilNextPrint = _tickToPrint;
    }

    get canPrint(){
        return this.tickUntilNextPrint <= 0
    }

    get percentToPrint(){
        return Math.floor(((this.tickToPrint - this.tickUntilNextPrint) / this.tickToPrint) * 100)
    }
}

const cryptoMiners = [
    new CryptoMiner(100, 0, 300),
    new CryptoMiner(500, 1000, 360),
    new CryptoMiner(2000, 5000, 480)
]

export{ cryptoMiners }