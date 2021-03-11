<template>
    <div class="slider">
        <div v-for="(image,index) in images" :key="index">
            <img src="../../assets/img/banner/food/3-5.jpg" alt="">
        </div>
    </div>
</template>

<script>
export default {
    name: "Slider",
    data() {
        return {
            images: [
                "../../assets/img/banner/food/4-1.jpg",
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
}
.slider img{
    width: 100%;
    min-height: 670px;
}
</style>