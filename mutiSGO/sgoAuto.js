
/**自動戰鬥
   * @param int limitHp
   * @param int limitPower
   * @param int floor
   *
   */
function autoFight(limitHp, limitPower, floor) {
   
    var status = "行動未完成";

    var baseUrl = "https://swordgale.online/"
    var profilePage = baseUrl + "profile";
    var huntPage = baseUrl + "hunt";
    var itemPage = baseUrl + "items";
    var marketPage = baseUrl + "market";
    var forgePage = baseUrl + "forge";
    var townPage = baseUrl + "town";
    var rankingsPage = baseUrl + "rankings";
    var reportsPage = baseUrl + "reports";

    //移到狩獵頁面
    //console.log(location.href);
    switch (location.href) {
        case profilePage:
            document.getElementsByClassName('chakra-link css-1dho2qc')[0].click();
            break;
        case itemPage:
        case marketPage:
        case forgePage:
        case townPage:
        case rankingsPage:
        case reportsPage:
            document.getElementsByClassName('chakra-link css-1dho2qc')[1].click();
            break;
    }

    //生命、體力
    var hp = parseInt(document.getElementsByClassName('css-zad53')[0].childNodes[0].childNodes[1].data);
    var power = parseInt(document.getElementsByClassName('css-zad53')[0].childNodes[1].childNodes[1].data);

    //完成移動
    if ((document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[0].data == '移動' &&
        document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '（可完成）') ||
        (document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '移動' &&
            document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[2].data == '（可完成）')
    ) {
        document.getElementsByClassName('chakra-button css-1adux0m')[0].click();
        status = "完成移動";
        _log(status);
        return false;
    }

    //完成休息 
    if ((document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[0].data == '休息' &&
        document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '（可完成）') ||
        (document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '休息' &&
            document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[2].data == '（可完成）')
    ) {
        document.getElementsByClassName('css-1myfyhp')[0].childNodes[3].click();
        status = "完成休息";
        _log(status);
        return false;
    }

    ////自動出門
    //if (document.getElementsByClassName('css-bxak8j')[0].childNodes[0].childNodes[1].textContent == '起始之鎮')
    //{
    //    document.getElementsByClassName('chakra-button css-vw2zy9')[0].click();
    //    setTimeout(function () { document.getElementsByClassName('chakra-button css-vw2zy9')[1].click(); }, 1000);
    //    status = " 去大草原";
    //}

    //超過指定樓層回家
    var getFloor = document.getElementsByClassName('css-bxak8j')[0].childNodes[0].childNodes[3].data;
    if (parseInt(getFloor) > floor)
    {
        document.getElementsByClassName('chakra-link css-1dho2qc')[0].click();
        setTimeout(function () { document.getElementsByClassName('css-z30qqj')[0].children[0].click(); }, 1000);
        status = "超過" + floor+"樓層回家";
        _log(status);
        return false;
    }


    //自動戰鬥、自動休息
    if (power > limitHp && hp > limitPower &&
        (document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[0].data == '閒置' ||
            document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '閒置'
        )
    ) {
        document.getElementsByClassName('css-1myfyhp')[0].children[1].click();
        status = "自動戰鬥";
        _log(status);
        return false;
    } else {
        if (document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[0].data == '閒置' ||
            document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '閒置'
        ) {
            document.getElementsByClassName('css-1myfyhp')[0].children[2].click();
            status = "自動休息"
            _log(status);
            return false;
        }
    };
    _log(status);
}

function autoForward() {

    var hp = parseInt(document.getElementsByClassName('css-zad53')[0].childNodes[0].childNodes[1].data);
    var power = parseInt(document.getElementsByClassName('css-zad53')[0].childNodes[1].childNodes[1].data);
    if (document.getElementsByClassName('css-1riv80w')[0].childNodes[1].childNodes[1].data == '（可完成）') {
        document.getElementsByClassName('css-1myfyhp')[0].childNodes[3].click();
    }
    if (power > 120 && hp > 120) {
        document.getElementsByClassName('css-1myfyhp')[0].children[0].click();
    }
    else {
        document.getElementsByClassName('css-1myfyhp')[0].children[2].click();
    };
}

function _log(Msg) {
    console.log(Msg);
}


