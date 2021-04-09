<template>
    <div class="slider-zoom">
        <div class="slider-zoom-content">
            <img src="../../assets/img/banner/food/3-1.jpg" alt="">
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            
        }
    },
}
</script>
<style scoped>
.slider-zoom img{
    width: 100%;
    margin-top: 30px;
    height: 650px;
    text-transform: capitalize;
    transition: all 0.3s ease-in-out;
}
.slider-zoom:hover
{
    -webkit-transform: scale(1.01);
    -ms-transform: scale(1.01);
    transform: scale(1.01);
}
</style>