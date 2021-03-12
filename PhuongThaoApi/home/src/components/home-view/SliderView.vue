<template>
    <div class="slider">
        <!-- <div v-for="(image,index) in images" :key="index">
            <img :src="img" alt="">
        </div> -->
        <div class="left-arrow">
            <i class="fa fa-angle-left" aria-hidden="true"></i>
        </div>
        <div class="right-arrow">
            <i class="fa fa-angle-right" aria-hidden="true"></i>
        </div>
        <img src="../../assets/img/banner/food/3-5.jpg" alt="" srcset="">
    </div>
</template>

<script>
export default {
    name: "Slider",
    data() {
        return {
            images: [
                "../../../assets/img/banner/food/4-1.jpg",
                "../../assets/img/banner/food/3-5.jpg"
            ],
            img: "../../assets/img/banner/food/3-5.jpg"
        }
    },
}
</script>
<style scoped>
.slider{
    min-height: 670px;
    width: 100%;
    margin-top: 35px;
}
.slider img{
    width: 100%;
    min-height: 670px;
}
.slider:hover .left-arrow,.slider:hover .right-arrow{
    display: block;
}
.left-arrow,.right-arrow{
    position: absolute;
    z-index: 1;
    background: rgba(0,0,0, 0.4);
    height: 45px;
    width: 45px;
    top: 500px;
    opacity: 0.5;
    cursor: pointer;
    color: white;
    font-size: 25px;
    line-height: 45px;
    display: none;
}
.left-arrow:hover,.right-arrow:hover{
    background: red;
    opacity: 0.4;
}
.left-arrow{
    left: 10px;
}
.right-arrow{
    right: 10px;
}
.left-arrow i,.right-arrow i{
    margin: 0px 18px;
}

</style>