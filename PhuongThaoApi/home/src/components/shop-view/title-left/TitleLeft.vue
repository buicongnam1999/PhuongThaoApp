<template>
    <div class="title-content">
        <div class="title-content-header">
            {{title}}
        </div>
    </div>
</template>
<script>
export default {
    data() {
        return {
            
        }
    },
    props: {
        title: String
    }
}
</script>
<style scoped>
.title-content-header{ 
    font-size: 22px;
    font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
    padding-bottom: 5px;
    margin-left: 20px;
    margin-top: 20px;
}
</style>