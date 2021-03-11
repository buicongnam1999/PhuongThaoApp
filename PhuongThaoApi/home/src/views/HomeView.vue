<template>
    <div>
        <slider-view />
    </div>
</template>

<script>
import SliderView from '../components/homeview/SliderView.vue'
export default {
    components: { 
        SliderView 
    },
    data() {
        return {
            images: [
                "../../assets/img/banner/food/4-1.jpg",
                "../../assets/img/banner/food/3-5.jpg"
            ]
        }
    },
    
}
</script>
<style scoped>

</style>