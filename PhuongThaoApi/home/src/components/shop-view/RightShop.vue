<template>
    <div class="right">
        <div class="grid-top">
            <div class="grid-top-left">
                <div style="margin:28px 10px 0 20px">
                    <img src="../../assets/icon/toggle.png" alt="" srcset="" width="30px" height="30px">
                </div>
                <!-- <div class="common">
                    <i class="fa fa-th-list" aria-hidden="true"></i>
                </div> -->
            </div>
            <div class="grid-top-sort">
                Sort By:
                <div class="input-sort">
                    <div class="input-sort-text">
                        Relavance
                    </div>
                    <div class="input-sort-button">
                        <i class="fa fa-angle-down" aria-hidden="true"></i>
                    </div>
                </div>
            </div>
        </div>
        <div class="grid-content">
            <div class="grid-content-product">
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
                <grid-element>
                    <img src="../../assets/img/products/food/2.jpg" alt="" srcset="" height="327px" width="270px">
                    <div class="grid-element-text">Ice Cream</div>
                    <div class="grid-element-price"><b>$72</b></div>
                </grid-element>
            </div>
        </div>
    </div>
</template>
<script>
import GridElement from './GridElement.vue'
export default {
    components:{
        GridElement
    }
}
</script>
<style scoped>
.right{
    width: 980px;
    height: 1910px;
}
.grid-top{
    border: 1px solid #e5e5e5;
    height: 80px;
    background-color: white;
    display: flex;
}
.grid-top-left{
    display: flex;
}
.common i{
    color: black;
    margin: 30px 0px;
    font: 50px;
}
.grid-top-sort{
    width: 355px;
    line-height: 80px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
    display: flex;
    justify-content: flex-end;
    width: 95%;
}
.input-sort{
    border: 1px solid #e5e5e5;
    border-radius: 4px;
    height: 35px;
    width: 290px;
    display: flex;
    justify-content: flex-end;
    margin:22.5px 10px;

}
.input-sort-text,.input-sort-button{
    line-height: 36px;
}
.input-sort-text{
    margin-left: 10px;
    width: 90%;
}
.input-sort-button{
    margin-right: 10px;
    justify-content: flex-end;
}
.grid-content{
    margin-top: 25px;
}
.grid-content-product{
}
.grid-element-text{
    margin-top: 20px;
    cursor: pointer;
}
.grid-element-text:hover{
    color: red;
    opacity: 0.9;
}
.grid-element-price{
    margin-top: 10px;
    font-size: 15px;
}
</style>