<template>
    <div class="paging">
        <div class="paging-left">
            <span style="color: #e5e5e5;">Hiển thị</span><b> 01-20/123 </b><span style="color: #e5e5e5;"></span>
        </div>
        <div class="paging-center">
            <div class="paging-center-back">
                <div class="first-page"><img src="../../assets/icon/btn-firstpage.svg" alt="" srcset=""></div>
                <div class="prev-page"><img src="../../assets/icon/btn-prev-page.svg" alt=""></div>
            </div>
            <div class="paging-center-page">
                <button style="background-color: #019160;">1</button>
                <button>2</button>
                <button>3</button>
                <button>4</button>
            </div>
            <div class="paging-center-up">
                <div class="next-page"><img src="../../assets/icon/btn-next-page.svg" alt="" srcset=""></div>
                <div class="last-page"><img src="../../assets/icon/btn-lastpage.svg" alt="" srcset=""></div>
            </div>
        </div>
        <div class="paging-right">
            <span><b>20&nbsp;</b></span><span style="color: #e5e5e5;">/trang</span>
        </div>
    </div>
</template>

<script>
export default {
    
}
</script>

<style scoped>
.paging{ 
    padding: 0px 0px 0px 16px;  
    font-size: 11px;
    margin-top:10px;
    height: 56px;
    width: 99%;
    display: flex;
    line-height: 56px;
}   
    .paging .paging-left{
        justify-content: left;
        width: 14%;
    }
    /*Center paging*/
    .paging .paging-center{
        justify-content: center;
        width: 73%;
        text-align: center;
        display: flex;
    }


        .paging .paging-center .paging-center-back{
            width: 25%;
            display: flex;
            justify-content: flex-end;
            position: relative;
            top: 8px;
        }
            .paging-center .paging-center-back .first-page{
                width: 25%;
                justify-content: flex-start;
            }
            .paging-center .paging-center-back .prev-page{
                width: 25%;
                justify-content: flex-end;
            }


        .paging .paging-center .paging-center-page{
            width: 35%;
            display: flex;
            justify-content: center;
        }
            .paging-center .paging-center-page button{
                width: 11%;
                height: 30px;
                margin-left: 10px;
                border-radius: 15px;
                border: 1px solid #e5e5e5;
                outline: none;
                cursor: pointer;
                background-color: #fff;
                position: relative;
                top: 13px;
            }
            .paging-center .paging-center-page button :hover{
                background-color: red;
            }


        .paging .paging-center .paging-center-up{
            width: 25%;
            display: flex;
            justify-content: flex-start;
            position: relative;
            top: 8px;
        }
            .paging-center .paging-center-up .next-page{
                width: 25%;
                justify-content: flex-start;
            }
            .paging-center .paging-center-up .last-page{
                width: 25%;
                justify-content: flex-start;
            }


    .paging .paging-right{
        justify-content: right;
        width: 13%;
    }
</style>