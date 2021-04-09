<template>
    <div>
        <img :src="require(`../../assets/img/products/food/${img}`)" alt="" srcset="" width="100px" height="100px">
    </div>
</template>

<script>
export default {
    data() {
        return {
            
        }
    },
    props:{
        img: String
    }
}
</script>

<style scoped>

</style>