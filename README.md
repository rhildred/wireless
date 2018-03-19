# wireless
my notes for wireless

## Compare and contrast the characteristics of different wireless standards.

|Standard|Frequencies|Range|Bandwidth|
|--|--|--|
|NFC|13.56 MHz|10 cm|424 kbit/s|
|Bluetooth|2.4 GHz|1-2.1 mbits/s|

## mitigating collisions

![collision from flowchart](https://rhildred.github.io/wireless/readmeimages/US4063220-4.png "collision from flowchart")

The [original ethernet patent](https://patents.google.com/patent/US4063220) submitted by Metcalfe and others contained a provision for packets lost in the "ether." Ironically he cites the ALOHAnet as inspiration. You may remember from the talk that the ALOHAnet was wireless too.

## collisions in wireless communications.

![802.11 Distributed coordination function](https://rhildred.github.io/wireless/readmeimages/maxresdefault.jpg "802.11 Distributed coordination function")

Even more ironically the Distributed coordination function (DCF) used by 802.11 is designed to prevent collisions like the ALOHAnet is designed to prevent collisions rather than deal with them after the fact.
