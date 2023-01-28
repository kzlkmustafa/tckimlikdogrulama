


 async function getAccount() {
    if (!window.ethereum) {
        document.getElementById("showAccount").value = '----'
        return false
    }
    const accounts = await ethereum.request({ method: 'eth_requestAccounts' });
    const account = accounts[0];
    console.log(account);

     document.getElementById("showAccount").value = account;
}

