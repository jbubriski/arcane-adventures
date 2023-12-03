(function () {
    var elements = document.getElementsByClassName('dice-roll');

    for (var i = 0; i < elements.length; i++) {
        log('Attaching:', elements[i]);

        elements[i].addEventListener('mousedown', function(e) { rollDice(this, e); })
    }

    function rollDice(element, e) {
        e.preventDefault();

        log('Rolling:', element);

        var rollType = element.dataset.rollType;
        var result = calculateDiceRoll(element.innerHTML);

        log(result);

        var rollsStrings = result.rolls.map((x) => x.roll);

        showToast(rollType, `${rollsStrings.concat(result.adds).join(' + ')} = ${result.totalValue}`);
    }

    function calculateDiceRoll(rollText) {
        var rolls = [];
        var adds = [];
        var totalValue = 0;

        log(rollText);

        var rollParts = rollText.split('+');

        log(rollParts);

        for (var j = 0; j < rollParts.length; j++) {
            var rollPart = rollParts[j].trim();

            log('Part: ' + rollPart);

            if (!isNaN(rollPart)) {
                console.log('Adding ' + rollPart);

                adds.push(+rollPart);

                totalValue += +rollPart;
                continue;
            }

            var rollParts2 = rollParts[j].trim().split('d');
            var numberOfDice = rollParts2[0].trim();
            var dieNumber = rollParts2[1].trim();

            for (var k = 0; k < numberOfDice; k++) {
                var roll = Math.ceil(Math.random() * dieNumber);

                totalValue += roll;

                rolls.push({
                    dieNumber: dieNumber,
                    roll: roll
                });

                console.log(rolls);
            }
            console.log(rollParts2);
        }

        return {
            rolls: rolls,
            adds: adds,
            totalValue: totalValue
        };
    }

    function showToast(messageType, message) {
        var snackbar = document.getElementById("snackbar");

        var newMessageRow = document.createElement("div");
        newMessageRow.className = 'roll-row';

        var rollTypeColumn = document.createElement("div");
        rollTypeColumn.className = 'roll-column';
        rollTypeColumn.innerText = messageType;

        var rollColumn = document.createElement("div");
        rollColumn.className = 'roll-column';
        rollColumn.innerText = message;

        newMessageRow.append(rollTypeColumn);
        newMessageRow.append(rollColumn);

        snackbar.append(newMessageRow);
        snackbar.className = "show";

        setTimeout(function () {
            tryCloseToast(newMessageDiv);
            //snackbar.className = snackbar.className.replace("show", "");
        }, 10000);
    }

    function tryCloseToast(messageDiv) {
        messageDiv.remove();

        var snackbar = document.getElementById("snackbar");

        if (snackbar.childNodes.length === 0) {
            snackbar.className = snackbar.className.replace("show", "hide");
        }
    }

    function log(message, message2) {
        if (message2) {
            console.log(message, message2);
        } else {
            console.log(message)
        }
    }
})();
