
//api confing

//取得狀態
const getProfileConfig = {
    url: 'https://api.swordgale.online/api/profile',
    method: 'get',
    headers: { 'token': localStorage.token },
};

//完成行動
const completeConfig = {
    url: 'https://api.swordgale.online/api/action/complete',
    method: 'post',
    headers: { 'token': localStorage.token },
}

//完成移動
const zoneCompleteConfig = {
    url: 'https://api.swordgale.online/api/zone/move/complete',
    method: 'post',
    headers: { 'token': localStorage.token },
}


//回城
const backConfig = {
    url: 'https://api.swordgale.online/api/zone/move/0',
    method: 'post',
    headers: { 'token': localStorage.token },
}

//出門 (大草原)
const goConfig = {
    url: 'https://api.swordgale.online/api/zone/move/1',
    method: 'post',
    headers: { 'token': localStorage.token },
}


//戰鬥-hunt
const huntConfig = {
    url: 'https://api.swordgale.online/api/hunt',
    method: 'post',
    headers: { 'token': localStorage.token },
    data: { 'type': 1 }
}
//戰鬥-team
const teamConfig = {
    url: 'https://api.swordgale.online/api/team',
    method: 'get',
    headers: { 'token': localStorage.token },
}
//戰鬥-invitations
const invitationsConfig = {
    url: 'https://api.swordgale.online/api/invitations',
    method: 'get',
    headers: { 'token': localStorage.token },
}
//戰鬥-info
const infoConfig = {
    url: 'https://api.swordgale.online/api/hunt/info',
    method: 'get',
    headers: { 'token': localStorage.token },
}

//休息
const restConfig = {
    url: 'https://api.swordgale.online/api/action/rest',
    method: 'post',
    headers: { 'token': localStorage.token },
}

//重生
const reviveConfig = {
    url: 'https://api.swordgale.online/api/action/revive',
    method: 'post',
    headers: { 'token': localStorage.token },
}

/**自動戰鬥
   * @param int limitHp
   * @param int limitPower
   * @param int floor
   *
   */
async function autoFight(limitHp, limitSp, floor) {

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
    var data; //api response
    let getNow = Date.now();
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
    try {

        //call profile api
        axios(getProfileConfig)
            .then(function (response) {
                data = response.data;
            }).catch(function (error) {
                console.log("api no response");
                return false
            });

        //等待
        await delay(1);

        //生命、體力
        var hp = data.hp;
        var sp = data.sp;

        //自動出門
        if (hp > 0 && data.huntZone == 0 && data.actionStatusCode == "free") {
            axios(goConfig);
            status = " 去大草原";
            _log(status);
            return false;
        }

        //完成移動
        if (typeof (data.movingCompletionTime) != "undefined" &&
            data.actionStatusCode == "moving" &&
            getNow > data.movingCompletionTime
        ) {
            axios(zoneCompleteConfig);
            status = "完成移動";
            _log(status);
            return false;
        }

        //完成休息 
        if (data.actionStatusCode == "resting" && data.canCompleteAction == true) {
            axios(completeConfig);
            status = "完成休息";
            _log(status);
            return false;
        }

        //完成復活
        if (data.actionStatusCode == "reviving" && data.canCompleteAction == true) {
            axios(completeConfig);
            status = "完成復活";
            _log(status);
            return false;
        }

        //超過指定樓層回家
        var getFloor = data.huntStage;
        if (parseInt(getFloor) > parseInt(floor) &&
            data.actionStatusCode == "free"
        ) {
            axios(backConfig);
            status = "超過" + floor + "樓回家";
            _log(status);
            return false;
        }

        //復活
        if(data.actionStatusCode == "free" && hp == 0)
        {
            axios(reviveConfig);
            status = '重生';
            _log(status);
            return false;
        }

        //自動戰鬥、自動休息
        if (sp > limitHp && hp > limitSp &&
            data.actionStatusCode == "free" //&&
            //getNow > data.canAttackTime
        ) {
            //調整中  還沒找到方法更新戰鬥紀錄
            // axios(teamConfig);
            // axios(invitationsConfig);
            // axios(infoConfig);
            // axios(huntConfig);
            // axios(infoConfig);
            // axios(teamConfig);
            //調整中
            document.getElementsByClassName('css-1myfyhp')[0].children[1].click();
            status = "自動戰鬥";
            _log(status);
            return false;
        } else if (data.actionStatusCode == "free") {
            axios(restConfig);
            status = "自動休息"
            _log(status);
            return false;
        };
        _log(status);
    } catch (e) {
        _log(e);
        _log(status);

    }
}

//自動趕路
async function autoForward() {

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
    var data; //api response
    let getNow = Date.now();

    //移到狩獵頁面
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

    //call profile api
    axios(getProfileConfig)
        .then(function (response) {
            data = response.data;
        }).catch(function (error) {
            console.log("api no response");
            return false
        });
    //等待
    await delay(1);

    //生命、體力
    var hp = data.hp;
    var sp = data.sp;

    //完成休息 
    if (data.actionStatusCode == "resting" && data.canCompleteAction == true) {
        axios(completeConfig);
        status = "完成休息";
        _log(status);
        return false;
    }

    //自動趕路、自動休息
    if (sp > 120 && hp > 120 &&
        data.actionStatusCode == "free"
    ) {
        document.getElementsByClassName('css-1myfyhp')[0].children[0].click();
        status = "自動戰鬥";
        _log(status);
        return false;
    } else if (data.actionStatusCode == "free") {
        axios(restConfig);
        status = "自動休息"
        _log(status);
        return false;
    };
    _log(status);
}

function delay(n) {
    return new Promise(function (resolve) {
        setTimeout(resolve, n * 1000);
    });
}

function _log(Msg) {
    console.log(Msg);
}


