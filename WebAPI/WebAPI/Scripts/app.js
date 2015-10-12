$(document).ready(function () {
    
    var keys = document.querySelectorAll('#calculator span');
        var rightPanel = $("#scene");
    var fibonacciDom = $("#FibonacciSeries");
    var fullSeriesDom = $("#FullSeries");
    var evensDom = $("#evens");
    var oddsDom = $("#odds");

    var cDom = $("#c");
    var eDom = $("#e");
    var zDom = $("#z");

    for (var i = 0; i < keys.length; i++) {
        keys[i].onclick = function (e) {
            // prevent page jumps
            e.preventDefault();

            var input = document.querySelector('.screen');
            var inputVal = input.innerHTML;
            var btnVal = this.innerHTML;

            if (btnVal == 'C') {
                input.innerHTML = '';
            } else if (btnVal == '=') {
                //full series
                var f = ResponseWrapper("api/fullseries/", inputVal);
                fullSeriesDom.text(f);

                //fibonacci
                var r = ResponseWrapper("api/fibonacci/", inputVal);
                fibonacciDom.text(r);

                //even
                var evens = ResponseWrapper("api/even/", inputVal);
                evensDom.text(evens);
                //odd
                var odds = ResponseWrapper("api/odd/", inputVal);
                oddsDom.text(odds);

                //c
                var c = ResponseWrapper("api/c/", inputVal);
                cDom.text(c);

                //e
                var e = ResponseWrapper("api/e/", inputVal);
                eDom.text(e);

                //z
                var z = ResponseWrapper("api/z/", inputVal);
                zDom.text(z);
            } else {
                input.innerHTML += btnVal;
            }

            
        }
    }
});

function ResponseWrapper(url, n) {
    var ret;
    $.ajax({
        type: "GET",
        url: url + n,
        data: {},
        success: function (response) {
            ret = response;
        },
        dataType: 'json',
        async: false
    });
    return ret;
}